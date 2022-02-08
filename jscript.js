async function sendreq() {
let url = 'http://localhost:8080/api/req/?_username='+document.getElementById('textbox1').value;
let response = await fetch(url);
let resulttext = await response.text();
let isadm = false;
if (resulttext=='true')
	isadm=true;
if (isadm) document.location.href = "true.html";
else document.location.href = "false.html";
}
async function returnto()
{
	document.location.href = "main.html";
}
 

