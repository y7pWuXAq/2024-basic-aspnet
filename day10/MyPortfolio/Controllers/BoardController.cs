using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public async Task<IActionResult> Index()
        {
            // AppDVContext(DB핸들링객체)안의 Board DBSet객체에다가
            // 들어있는 데이터를 리스트로 가져와서
            // 화면으로 보낸 다음에 출력하라
            // Views/Board/Index.cshtml을 화면에 뿌려라
            return View(await _context.Board.ToListAsync());
        }

        // GET: Boards/Details/5
        public async Task<IActionResult> Details(int? id)
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
