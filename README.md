## 2024-basic-aspnet
IoT 개발자 과정 ASP.NET 학습 리포지토리



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

            <p><strong>Lorem</strong> ipsum dolor sit, <b>amet</b> consectetur adipisicing elit.
                <br><em>Odit qui pariatur recusandae dolor,</em>
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
        - span : 인라인 형식(한 줄)으로 공간 분할

    - HTML + CSS + Javascript
        - 내부 스타일, 외부 스타일, 인라인 스타일
        - 내부 스크립트, 외부 스크립트, 인라인 스크립트

    - 오류, 디버그
        - 웹 브라우저에서 F12 개발자 도구로 활용



### DAY 02

- HTML5
    - 시맨틱 웹 : 시맨틱 태그로 화면의 구조를 잡는 웹구성 방식
        - header, nav, footer, aside, section, article ... 태그 사용
        - 시맨틱 태그를 <div>로 바꿔도 동작 이상 없기 때문에 요새는 많이 사용하지 않음. 걷어내고 있는 추세

- CSS3
    - 웹 디자인 핵심, Cascading Style Sheets
    - 상단의 <body> 부터 하위 태그들에 계속해서 적용되는 스타일이라는 뜻
    - 선택자에게 주어지는 디자인 속성
    - 선택자 (selector)
    - 속성 (property)

    - 배경, 폰트 ...
        - https://fonts.google.com/?subset=korean
        - http://css3generator.com/\
        - https://cssgenerator.org/

    - 레이아웃
        - HTML만으로는 화면 레이아웃이 만들어지지 않음
        - 중앙정렬, OneTrueLayout, 고정바 ... 
    
    - 반응형 웹(Responsive Web)
        - 메타 태그 viewport를 사용하면 그때부터 반응형 웹이 된다.
        
        ```html
        <meta name='viewport' content='width=device-width, initial-scale=1'>
        ```

        - @media 태그 : 디바이스 종류별로 CSS 따로 디자인 가능



### DAY 03

- 자바스크립트(Javascript)
    - 스크립트 언어, ECMAScript
    - 웹 브라우저 주로 사용
    - 바닐라 스크립트 : 기본에 충실한 자바스크립트
    - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
    - Node.js : 자바스크립트로 백엔드를 구현(파이썬과 유사)
    
    - 특징
        - 자료형 선언이 없음. var 변수 선언
        - 인터프리터 언어 (not Compile Lang)
        - 확장자 .js
        - 속도가 컴파일 언어에 비해서 느림.
        - VS Code도 자바스크립트로 만든 앱
        - 문장 끝 ';'은 생략 가능하지만 사용 권장
        - 정수와 실수 구분 없음
        - 0으로 나눠도 예외가 발생하지 않음
        - 파이썬과 동일하게 ', " 모두 사용
        - 완전히 동일함을 비교하는 연산자 '===' 자바 스크립트밖에 없음
        - 변수 선언 시 let(일반), var(지역변수), const(상수)
        - **HTML 태그와 연계(DOM) 중요!**
        
    - DOM(Document Object Model) !!
        - 실행 순서!
        - HTML에 있는 모든 요소를 제어할 수 있음
        - HTML 애니메이션, 게임, 통신 모두 가능
        - 이벤트 on~ 으로 시작
            - onload : 화면이 다 렌더링되면 그 다음 발생
            - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
            - onclick : 객체를 마우스로 클릭하면 발생
            - ondbclick : 더블클릭하면 발생
            - onmousemove : 마우스를 이동하면 발생
            - onmouseover : 객체 위에 마우스가 올라가면 발생
            - onkeydown, onkeypress : 객체에서 키보드를 타이핑하면 발생
            - 그 외 ...
    
    - jQuery
        - 자바스크립트 라이브러리
        - js를 매우 편리하게 사용할 수 있도록 도와주는 서포트 라이브러리
        - 순식간에 웹개발 업계를 장악했던 라이브러리
        - 사용빈도가 줄고 있지만 아직도 80% 웹사이트가 사용 중
        - js 파일 다운로드 후 사용하거나
        - CND 링크(https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js")를 사용하는 방법(링크사용 추천!)



### DAY 04

- HTML + CSS + js(jQuery) 응용
    - jQuery 응용
        - javascript와 jQuery를 혼용해도 상관 없음
        - jQuery로 코딩이 편할 때와 javascript가 편할 때가 있음.

    - Bootstrap 응용
        - 오픝소스 CSS 프레임워크
        - 트위터 블루프린트 -> 부트스트랩
        - 현재 전세계에서 가장 각광받는 프레임워크 중 하나
        - CSS를 동작시키기 위해서 Javascript도 포함
        - 소스를 다운받아서 사용(1), CDN으로 링크만 사용(2)
            - 제한된 네트워크에서는 1번 방법으로 사용
            - 항상 인터넷이 연결 된 사용에서는 2번 방법이 편리함
        - Bootstrap 참고 사이트 : https://getbootstrap.com/

        - 핵심!
            - Bootstrap은 화면 사이즈를 12등분
                - 12를 넘어서면 디자인이 깨짐 !주의!
            - container 밑에 마치 table처럼 div를 구분해서 사용
            - container > row > col 처럼 div 태그 클래스 정의
            - 부트스트랩 학습에 시간을 들일 필요X Copyleft 정석
                - 스니펫 활용 추천
                - https://getbootstrap.com/docs/5.3/getting-started/introduction/
                - https://getbootstrap.com/docs/5.3/examples/

            - 무료 테마(템플릿) 아주 잘 되어 있음
                -  https://startbootstrap.com/

    - 웹 페이지 클로닝
        - 핀터레스트 + 부트스트랩 타입 웹페이지 만들기(진행중)



### DAY 05

- HTML + CSS + js(jQuery) 응용
    - 웹 페이지 클로닝
        - 핀터레스트 + 부트스트랩 타입 웹페이지 만들기(완료!)


        https://github.com/y7pWuXAq/2024-basic-aspnet/assets/158008080/edf729f7-08f3-49f8-ada1-59dfaea9c90a


    - Codehal 유튜버 로그인 웹페이지 듀토리얼 따라하기
        <img src="https://raw.githubusercontent.com/y7pWuXAq/2024-basic-aspnet/main/images/an001.png" width="730" alt="Codehal 로그인창 따라하기"> 



### DAY 06 - 07

- HTML + CSS + js(jQuery) 응용
    - 웹 페이지 클로닝
        - 핀터레스트 + 부트스트랩 타입 웹페이지 듀토리얼 따라하기


        https://github.com/y7pWuXAq/2024-basic-aspnet/assets/158008080/f0f5594a-0263-4545-ad87-a02094085e8b


    - 웹 페이지 클로닝 : 스크롤 페이지


        https://github.com/y7pWuXAq/2024-basic-aspnet/assets/158008080/01838f83-405d-425d-a152-3a63ab6da07e

    
    - 웹 페이지 클로닝 : 이미지 슬라이더


        https://github.com/y7pWuXAq/2024-basic-aspnet/assets/158008080/58f881ef-6308-4f78-aa43-a709d827879e



### DAY 08

- ASP.NET
    - ASP.NET의 역사
        - 1990년대 MS가 웹 서버기술로 ASP(Active Server Page)를 배포. like JSP(Java Sever Page)
        - ASP는 .NET으로 된 언어가 아닌, VBScript를 사용. 타입 확장자(*.asp)
        - 개발이 쉬워서 많이 사용함
        - 스파게티 코드 : HTML + CSS + JavaScript + VBScript 모두 사용해 만든 웹 페이지
        - 유지보수가 어렵고 성능이 나쁨

        - 2000년대 MS가 .NET Framwork를 발표.
        - C#, VB.NET, C++.NET 등의 새로운 언어를 배포, 여기에 맞춰서 웹 서버기술을 다시 만듬 > ASP.NET
        - 가장 큰 장점은 윈폼 개발 하는 것처럼 웹 개발을 할 수 있었음.
        - 초창기에 스파게티 코드를 거의 그대로 사용, 성능도 안좋음!
        - 2009년 ASP.NET MVC(Model View Controller 디자인 패턴)공표, 성능은 좋아짐.
        - 하지만 윈도우에서만 동작
        - 모든 OS 플랫폼에서 동작할 수 있는 .NET Core를 재출시.
        - 거기에 웹 서버기술을 또다시 만듬 > ASP.NET Core
    
    - .NET Core(현재는 .NET 9.0, Core라는 이름은 사용X)의 장점
        - 빠르고 오픈소스
        - 크로스 플랫폼, OS에 종속받지 않음
        - 성능 좋음.
    
    - ASP.NET 종류
        - ~~ASP.NET webforms : 2000년도 초반에 나오다가 사장된 웹사이트 개발기술~~
        - **ASP.NET Core웹 앱(MVC) : 가장 기본적인 프론트엔드(HTML, CSS, JS .cshtml) + 백엔드 (C# .aspx.cs) 웹개발**
        - **ASP.NET Core웹 API : 데이터포털, 네이버, 카카오, 영화API 사이트를 만드는 백엔드 (프론트엔드가 없어서 화면이 없음)**
        - ~~Edge용 웹 드라이버 테스트 : 엣지 브라우저에 종속된 테스트 용~~
        - Js(Veu, Angular, React) 프론트엔드 + ASP.NET Core 백엔드
        - ASP.NET Core gRPC 서비스 : 고성능 원격프로시저호출(스트리밍 호출) 서비스
        - Blazor : Js 프론트엔드를 따라서 C# 컴포넌트 기반으로 개발하는 웹 개발 방식 웹사이트 개발
        - Razor : 프론트엔드 개발에 C# 코드가 특화되서 사용되는 웹사이트 개발방식
        - .NET Aspire : Blazor 프론트엔드 + Redis + 웹 API 백엔드

    - 참조사이트
        - https://learn.microsoft.com/ko-kr/aspnet/core/?view=aspnetcore-3.1
        - https://github.com/dotnet
        - https://mixedcode.com/
        - https://github.com/gilbutITbook/006824

    - ASP.NET Core 웹앱(MVC : Model-View-Controller)
        - 현재 기본적인 웹개발의 가장 표준
        - Java 계열도 Spring (Boot) MVC로 개발
        - MVC 개념도
            <img src="https://raw.githubusercontent.com/y7pWuXAq/2024-basic-aspnet/main/images/an002.png" width="730">

        - 예전에는 프론트엔드의 스파게티코드가 무지 심했다면 현재는 최소화 되어 있음(SpringBoot Python flask등 모두 동일)
        - IIS Express Server : VS에서 ASP.NET 웹사이트를 운영하는 개발용 웹서버 이름
        - index.* : 웹사이트 가장 대문되는 페이지 이름
        - 파일 저장 시 핫다시로드(HotReload) 체크하면 편함
        - @로 시작하는 C# 구문, Tag helper, HTML helper로 HTML구문 내에 C# 코드를 적어서 활용하는 방법 = Razor 구문
        - Action == HTML에서 from 태그 내 submit버튼 클릭! / 링크를 클릭하는 것, 윈앱에서 이벤트와 동일
        - 액션이 발생한 이후 처리하는 메서드의 결과를 ActionResult
        - 콘솔 서버로그 잘 확인할 것, 프로세스가 종료되면 웹사이트가 실행안됨

    - 데이터베이스 연동방법
        - DB first : 가장 전통적인 DB 연동방식. DB설계, DB구축, C#과 연동
        - code first : 최근 트렌드가 되는 DB 연동 방식. C#클래스 작성, DB연결 설정 후 실행하면 DB에 테이블이 생성
        - EntityFramework를 사용하면 아주 손쉽게 구축가능

    - EntityFramework(Core) 설치
        - Microsoft.EntityFrameworkCore
        - Microsoft.EntityFrameworkCore.Tools
        - Microsoft.EntityFrameworkCore.SqlServer

    - Code first 구현 순서
        - EF 패키지 설치
        - 엔티티 클래스 작성
        - appsetting.json에 DB연결 문자열 추가
        - Data/ApplicationDbContext.cs 중간연결 클래스 생성
        - Program.cs Services 내에 DbContext 종속성을 주입
        - NuGet 패키지 관리자 > 패키지 관리자 콘솔 실행
            ```shell
            PM> Add-migration (마이그레이션명)
            Build started...
            Build succeeded.
            ...
            PM> update-database
            ...
            Done.
            ```



### DAY 09(07.22 예정)

- ASP.NET Core MVC
    - 필요 이론
    - 연습
    - 개인 포트폴리오 웹사이드 (미리 디자인해보기!)
    - Bootstrap 테마 적용
