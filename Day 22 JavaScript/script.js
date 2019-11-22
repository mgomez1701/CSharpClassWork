console.log("Hey, snowy world.");
function displayEquals(){
// testing to see that === is literal and looks at the data types. == erases the datatypes for comparison.
let doubleEquals =(25 =="25");
let tripleEquals = (25 ==="25");

alert(`double equals ${doubleEquals}, triple equals ${tripleEquals}`);

}

function addNumbers(){

    let number1 = prompt("Give me a number");
    let number2 = prompt("Give me another number");
    number1 = parseInt(number1);
    number2 = parseInt(number2);
    alert(number1 + number2); 
}

function exerciseOne(){

    let userInput = prompt("Please enter your name:");
    
    if(userInput.length > 2){
        alert(`Hello ${userInput}!`);
    }
    else{
        exerciseOne();
    }
}
// document.write("Java and all things");
// // document.body.innerHTML = '<p> I changed the whole page!</p>';
// document.getElementById("happy");
happyId.innerText = "I changed just this paragraph";


let header = document.createElement("h1");
header.innerText = "This is a header!";
document.body.appendChild(header);
