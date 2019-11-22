document.querySelector("#colorParent").addEventListener("click", setColorBox);
// we need to create a function calld setColorBox
    function setColorBox(colorButton){
      if(colorButton.target.localName === "button"){
        let box = document.getElementById("colorBox");
        let color = colorButton.target.getAttribute("data-color");

        box.style.backgroundColor=color;
        let p = document.createElement("p");
        p.innerText=color; 

        box.appendChild(p);
      }

}