const btn = document.getElementById("btn");
const input = document.getElementById("input");

// btn.addEventListener("mouseenter", ChangeColor);
// btn.addEventListener("mouseleave", ResetColor);

function ChangeColor(){
    btn.style.backgroundColor = "red";
}

// function ResetColor(){
//     btn.style.backgroundColor = "gray";
// }

// input.addEventListener("focus", function(){
//     input.style.borderColor = "red";
// });


// input.addEventListener("blur", function(){
//     input.style.borderColor = "green";
// });

function WriteToLog(){
    console.log(input.value);
}