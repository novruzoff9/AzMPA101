const sumBtn = document.getElementById("sum");
const num1 = document.getElementById("num1");
const num2 = document.getElementById("num2");
const resultP = document.getElementById("result");

sumBtn.addEventListener("click", function () {
  let result = Number(num1.value) + Number(num2.value);
  resultP.innerText = result;
});
const subBtn = document.getElementById("sub");

subBtn.addEventListener("click", function () {
  let result = Number(num1.value) - Number(num2.value);
  resultP.innerText = result;
});

const devBtn = document.getElementById("dev");
devBtn.addEventListener("click", function () {
  if (num2.value == 0) {
    resultP.innerText = "sifira bolmek olmaz";
  } else {
    let result = Number(num1.value) / Number(num2.value);
    resultP.innerText = result;
  }
});

const hasilBtn= document.getElementById("hasil")

hasilBtn.addEventListener("click", function()
{
    let result =Number(num1.value * num2.value)
    resultP.innerText= result
})
