// const sumBtn = document.getElementById("sum");
// const resultP = document.getElementById("result");
// sumBtn.onclick = () => {
//     const num1 = document.getElementById("num1");
//     const num2 = document.getElementById("num2");

//     let sum = Number(num1.value) + Number(num2.value);
//     resultP.innerText += sum
// };

const imgInput = document.getElementById("imgInput");
function ShowImage(){
    document.getElementById("image").src = imgInput.value
}