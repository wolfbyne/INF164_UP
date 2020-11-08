current_count = 0;
var number = document.getElementById('num');
function increase(){
    number.innerHTML = current_count++;
}
function decrease(){
    number.innerHTML = current_count--;
}
function negPos(){
    if(current_count > 0)
    {
        number.style.color = "green";
    }else if(current_count < 0)
    {
        number.style.color = "red";
    }else if(current_count == 0)
    {
        number.style.color = "black";
    }
}