using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class BoardController : Controller
    {
        private readonly AppDbContext _context;

        public BoardController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Boards
        // FromSql()로 작업 할 때는 비동기 async, await, Task<>를 걷어내야 함
        public IActionResult Index(int page = 1, string search = "")
        {
            // AppDVContext(DB핸들링객체)안의 Board DBSet객체에다가
            // 들어있는 데이터를 리스트로 가져와서
            // 화면으로 보낸 다음에 출력하라
            // Views/Board/Index.cshtml을 화면에 뿌려라
            // return View(await _context.Board.ToListAsync());

            var totalCount = _context.Board.FromSqlRaw<Board>($"SELECT * FROM Board WHERE Title LIKE '%{search}%'").Count(); // 총 글 갯수
            var countList = 10; // 페이지별 게시글 수
            var totalPage = totalCount / countList; // 총 페이지 수

            if (totalCount % countList > 0) totalPage++; // 12 % 10 == 2 > 0 :: 한 페이지가 더 필요하니 추가하기
            if (totalPage < page) page = totalPage; // 현재 페이지 번호가 전체 페이지수보다 크면 축소

            var countPage = 10; // 아래 표시되는 페이지 번호 수
            var startPage = ((page - 1) / countPage) * countPage + 1; // 1~10 페이지, 11~20 페이지
            var endPage = startPage + countPage - 1; // 1페이지부터 시작하면 10페이지가 마지막
            if (totalPage < endPage) endPage = totalPage; // 2페이지가 마지막이면 endPage 10 > 2로 변경

            // 쿼리로 넘길 값
            var startCount = ((page - 1) * countPage) + 1; // 1, 11, 21 순으로
            var endCount = startCount + (countPage - 1); // 10, 20, 30,, 순으로

            // ViewData(Dict), ViewBag(Prop) 변수... (뷰 cshtml에서 사용할 변수)
            ViewBag.StartPage = startPage;
            ViewBag.EndPage = endPage;
            ViewBag.Page = page;
            ViewBag.TotalPage = totalPage;
            ViewBag.TotalCount = totalCount; // 전체 글 갯수
            ViewBag.Search = search; // 검색결과

            // var StartCount = new SqlParameter("@StartCount", startCount);
            // var EndCount = new SqlParameter("@EndCount", endCount);
            var list = _context.Board.FromSqlRaw($@"
                        SELECT *
                          FROM (
				                SELECT ROW_NUMBER() OVER(ORDER BY Id DESC) AS rowNum
			  		                 , Id
				  	                 , Name
				  	                 , UserId
				  	                 , Title
				  	                 , Contents
				  	                 , Hit
				   	                 , RegDate
				  	                 , ModDate
				                  FROM Board
                                 WHERE Title LIKE '%{search}%'
	                        ) AS base
                         WHERE base.rowNum BETWEEN {startCount} AND {endCount}
                    ").ToList();
            
            return View(list);
        }

        /* 게시글 상세 읽기 */
        // GET: Boards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board
                .FirstOrDefaultAsync(m => m.Id == id); // SELECT * FROM board WHERE
            if (board == null)
            {
                return NotFound();
            }

            // 게시글의 조회수를 1 증가
            board.Hit += 1;
            _context.Update(board); // 객체에 내용을 반영
            await _context.SaveChangesAsync(); // 실제 DB를 변경하는 것

            return View(board); // 게시글 하나를 뷰로 던져준다.
        }

        // GET: Boards/Create
        // 링크를 클릭해서 화면 전환
        public IActionResult Create()
        {
            // Views/Board/Create.cshtml 화면을 출력
            return View();
        }

        // POST: Boards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UserId,Title,Contents,Hit,RegDate,ModDate")] Board board)
        {
            // 아무값도 입력하지 않으면 ModelState.IsValid는 false
            if (ModelState.IsValid)
            {
                board.RegDate = DateTime.Now;
                board.ModDate = null;
                _context.Add(board);    // DB 객체에 저장
                // Insert to Commit 실행
                await _context.SaveChangesAsync();
                // 저장 후에 게시판 목록 화면으로 돌아감
                return RedirectToAction(nameof(Index));
            }
            return View(board);
        }

        // GET: Boards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board.FindAsync(id); // SELECT *FROM WHERE 절
            if (board == null)
            {
                return NotFound();
            }
            return View(board);     // edit.cshtml을 출력하라.
        }

        // POST: Boards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,UserId,Title,Contents,Hit,RegDate,ModDate")] Board board)
        {
            if (id != board.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // 수정 날짜 추가!
                    board.ModDate = DateTime.Now;
                    _context.Update(board); // 수정
                    await _context.SaveChangesAsync();  
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoardExists(board.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(board);
        }

        // GET: Boards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var board = await _context.Board
                .FirstOrDefaultAsync(m => m.Id == id);
            if (board == null)
            {
                return NotFound();
            }

            return View(board);
        }

        // POST: Boards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var board = await _context.Board.FindAsync(id);
            if (board != null)
            {
                _context.Board.Remove(board);   // 삭제
            }

            // DB Delete 후에 Commit
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoardExists(int id)
        {
            return _context.Board.Any(e => e.Id == id);
        }
    }
}
