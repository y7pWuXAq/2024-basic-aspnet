## 2024-basic-aspnet
IoT 개발자 과정 ASP.NET 리포지토리



### DAY 01

- 웹기술 개요
    - World Wide Web : 인터넷의 한 파트
    - Full-Stack
        - Front-end
            - 웹사이트 화면으로 사람들에게 보이는 부분 기술
        - Back-end
            - 웹사이트 뒤에서 동작하는 서버기술
        - Sever-Operation
            - HW, OS, SW 등 운영(클라우드)

- 업무용 웹사이트 참조
    - https://www.ecount.com/kr/ECK/ECK004M_CN.aspx

- Front-end(클라이언트)
    - HTML5
    - CSS3
    - Javascript

- Back-end(서버)
    - 1. Java
        - Spring, Spring Boot, JSP, EJB ...
    - 2. Javascript
        - Node.js, Express ...
    - 3. Python
        - Django, Flask, fastAPI ...
    - 4. C#
        - ASP.NET
    - 5. Ruby
        - Ruby on rails
    - 6. C
        - cgi, fasCGI ...
    - 7. PHP(사라지고 있는 중)

- 개발 시 사용
    - 프론트엔드 전부 사용 + 백엔드 여러개 중 하나 선택 + DB
    - 웹 브라우저에서 F12(개발자도구) 자주 사용
    - VS Code 플러그인
        - HTML Code Snippet
        - Live Server

- HTML5
    - Hyper Text Markup Language (HTML)
    - XML(eXtensible Markup Language)이 웹페이지를 구성하기 위한 선행기술 > 너무 복잡해서 간략화 시킨것
    - 기본 확장자 .html
    - Tip!! : lorem > 탭! > 긴 샘플 텍스트가 생성됨

    - 기본 태그 (body에 사용)

        - h1 ~ h6 : 제목(마크다운의 # 과 동일 h6으로 갈수록 글씨가 작아짐)

        ```html
        <body> <!-- 화면에 나타남! 문서의 구성 부분 -->
            <h1>Hello, HTML5 ^0^!</h1>

            <!-- h : 헤딩(제목1, 제목2 ~ 제목6) -->
            <!-- 글씨크기 1 > 6 -->
            <h2>Heading2</h2>
            <h3>Heading3</h3>
            <h4>Heading4</h4>
            <h5>Heading5</h5>
            <h6>Heading6</h6>
        </body>
        ```

        - 웹 페이지 적용 화면

        ![h1~h6 예시](https://raw.githubusercontent.com/y7pWuXAq/2024-basic-aspnet/main/images/aspn01.png)
        

        - p : 일반 문장
        - div : 그룹화 구분자, 아주 중요함!!(CSS 연계 디자인)
        - img : 이미지 표현
        - br : 한 줄 내리기(Enter)
        - 특수문자 : '&' 와 ';' 사이에 영문자로 표시, 종류가 아주 많음
            - lt : <
            - gt : >
            - amp : &
            - copy : ©
            - nbsp : 띄어쓰기
            - plusmn : ±
        - strong 또는 b : 볼드
        - em : 기울기
        - mark : 형광펜 효과
        - u : 밑줄
        - strike : 취소선

        ```html
        <body>
            <h1>첫 번째 제목</h1> <!-- 제목 -->
            <p>재밌는 웹프로그래밍 입문</p> <!-- 문장(paragraph) -->

            <div> <!-- <div> : 의미X, 그룹핑하는 것. 화면상 변화는 없음 -->
                <h1 title="header">두 번째 제목</h1> <!-- title="header" : h1의 속성 -->
                <p>나 : 진짜 재밌다고?</p>
                <img src="./cat.png"> <!-- 이미지 태그 -->
            </div>

            <p><strong>Lorem</strong> ipsum dolor sit, <b>amet</b> consectetur adipisicing elit.<br><em>Odit qui pariatur recusandae dolor,</em>
                <br>eius reiciendis quibusdam <mark>magnam beatae nulla</mark> accusamus consequatur
                <br><u>debitis</u> id dicta <strike>nesciunt</strike> saepe sequi esse iusto iste!</p>
            <p>특수기호 : &lt; &gt; &amp; &copy; &nbsp; &plusmn;</p>
        </body>
        ```

        - 웹 페이지 적용 화면

        ![웹 페이지](https://raw.githubusercontent.com/y7pWuXAq/2024-basic-aspnet/main/images/aspn02.png)


        - **a : 웹페이지 링크(중요!)**
        - ul : 순서 없는 목록
        - ol : 순서 있는 목록
        - table, tr, th, td : 테이블 생성

        ```html
        <body>
            <a href="https://www.namver.com">네이버</a> <!-- 기존 페이지를 덮고 새 페이지 열기 -->
            <a href="https://www.namver.com" target="_blank">네이버 새 탭에서 열기</a> <!-- target="_blank" : 새 탭에서 열기 -->
            <a href="mailto:메일주소@naver.com">메일보내기</a> <!-- mailto: 메일 보내기 안되는 경우도 많음 -->

            <div> <!-- 순번 없는 목록 ul -->
            <ul>
                <li>복숭아</li>
                <li>딸기</li>
                <li>바나나</li>
            </ul>
            </div>

            <div>
                <ol> <!-- 순번 있는 목록 ol -->
                    <li>봄
                        <ul> <!-- 따로 추가도 가능 -->
                            <li>벚꽃</li>
                            <li>중간고사</li>
                        </ul>
                    </li>
                    <li>여름</li>
                    <li>가을</li>
                    <li>겨울</li>
                </ol>
            </div>

            <!-- 테이블 -->
            <table border="1">
                <caption> <!-- 테이블에 제목을 쓸 때 -->
                    <strong>제목</strong>
                </caption>
                <tr>
                    <th>1번셀</th>
                    <th>2번셀</th>
                    <th>3번셀</th>
                    <th>4번셀</th>
                </tr>
                <tr>
                    <td>90</td>
                    <td>80</td>
                    <td colspan="2">95</td>
                </tr>
                <tr>
                    <td>90</td>
                    <td>80</td>
                    <td>95</td>
                    <td rowspan="2">100</td>
                </tr>
                <tr>
                    <td>90</td>
                    <td>80</td>
                    <td>95</td>
                </tr>
            </table>
            </body>
        ```
        
        - 웹 페이지 적용 화면

        ![웹 페이지](https://raw.githubusercontent.com/y7pWuXAq/2024-basic-aspnet/main/images/aspn03.png)


        - audio, video : 오디오, 비디오 
        - object, embed : 객체 추가

        ```html
        <body>
            <!-- 오디오, 비디오, PDF 추가 -->
            <audio controls>
                <source src="./sample.mp3">
            </audio><br><br>

            <video controls width="500">
                <source src="./sample.mp4">
            </video><br>

            <object type="application/pdf"
                data="./sample.pdf" 
                width="250" height="380">
        </body>
        ```

        - 웹 페이지 적용 화면

        ![웹 페이지](https://raw.githubusercontent.com/y7pWuXAq/2024-basic-aspnet/main/images/aspn04.png)


        - hr : 가로선
        - small : 글씨 작게
        - sub : 아래첨자
        - sup : 위 첨자

    - 양식 태그(body > Form 안에 사용 필수)
        - frint-end 에서 입력한 내용이 back-end로 보내기 위한 관문
        - form 을 반드시 사용

        - input
            - type="text" : 텍스트 박스
            - type="password" : 패스워드 박스
            - type="button" : 일반 버튼
            - **type="submit" : 제출(!)**
                - submit 클릭 시 loopback(값 전달) 발생
            - checkbox : 체크박스
            - radio : 라디오 버튼
            - file : 파일 업로드
            - image : 이미지 (img와 유사)
            - reset : 폼 내의 입력양식 태그 값 초기화
            - hidden : 숨김값(유용하게 사용!!)

        - textarea : 여러행 텍스트 입력
        - select : 콤보박스
        - fieldset : 그룹박스
        
        - 값 전달 방법
            - GET : URL 뒤 ? 다음에 key=value&key=value ... 방식으로 데이터를 전달하는 방식
            - POST : 화면 뒤로 숨겨서 데이터를 전달하는 방식
    
    - 공간 구분 태그
        - div : 블록 형식으로 공간 분할
        - span : 인라인 형식으로 공간 분할

    - HTML + CSS + Javascript
        - 내부 스타일, 외부 스타일, 인라인 스타일
        - 내부 스크립트, 외부 스크립트, 인라인 스크립트

    - 오류, 디버그
        - F12 개발자 도구로 활용



### DAY 02

- HTML5
    - 시맨틱 태그

- CSS3
    - 웹 디자인 핵심

- Javascript