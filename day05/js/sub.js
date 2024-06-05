/* 회전버튼 동작 */
const rotateBtn = document.querySelector('.rotate-btn');
const slides = document.querySelectorAll('.bg-slide');
const totalSlides = slides.length; // 5개
let index = 0;

// $('.rotate-btn').on('click', function(){}); 과 동일
rotateBtn.addEventListener('click', function() {
    rotateBtn.classList.add('active');
    setTimeout(() => {
        rotateBtn.classList.remove('active');
    }, 2100);
    
    slides.forEach(slide => {
        if (slide.classList.contains('active')) {
            slide.classList.add('after-active');
        } else {
            slide.classList.remove('after-active');
        }
    });

    slides[index].classList.remove('active'); // 현재 슬라이드는 active 제거
    index += 1;

    if (index == totalSlides) index = 0; // 마지막 슬라이드의 인덱스가 같아지면 인덱스 초기화
    
    slides[index].classList.add('active'); // 새 슬라이드에 active 추가
})