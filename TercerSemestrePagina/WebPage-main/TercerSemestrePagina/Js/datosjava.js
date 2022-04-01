
function Basedat(){
    var name = document.getElementById("name").value;
    var age = document.getElementById("age").value;
    if(name == ""){
        document.getElementById("name").focus();
    }else{
        if(age == ""){
            document.getElementById("age").focus();
        }else{
                console.log(name+" "+age);
                document.getElementById("name").value = "";
                document.getElementById("age").value = "";
                document.getElementById("name").focus();
            }
        
        
    }
   

}




