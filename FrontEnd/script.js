$(document).ready(function () {
    carregarLista()
    criaUsuario();
    //relatorio();
});


const criaUsuario = async function(){

    $(".btn-success").click(async function (e) { 
        e.preventDefault();
        
        const novoUsuario = await getUserCreate();
        console.log(JSON.stringify(novoUsuario[0]))
        console.log(novoUsuario[0])

        $.ajax({
            type: "POST",
            url: "https://localhost:7112/User",
            data: JSON.stringify(novoUsuario[0]),
            dataType: 'application/json',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            success: function (response) {
               alert(response) 
            },
            error: function (jqXHR, textStatus, errorThrown) { 
                console.log(errorThrown)
                
            }
        }); 
    });
}

const getUserCreate = async function(){
    const URL = "https://randomuser.me/api/";
    const request = await fetch(URL);
    const response = await request.json();
    console.log(response.results);
    return response.results;

}
const getUser = async function(){
    const URL = "https://localhost:7112/User";
    const request = await fetch(URL);
    const response = await request.json();
    //console.log(response);
    return response;

}

getUserRelatorio = () => {
    const filtro = $(".btn-info").val()
    $(".btn-info").click( async function (e) { 
        e.preventDefault();
        
        const URL = `https://localhost:7112/User/${filtro}`;
        const request = await fetch(URL);
        const response = await request.json()
        console.log(response)
        //return response
    });
}

const carregarLista = async function(){

    const response = await getUser();

    response.map(user => {
        let html =
        `
        <tr class="">
            <td scope="row" hidden>${user.login.uuid}</td>
            <td scope="row">${user.name.first}</td>
            <td>${user.name.last}</td>
            <td>
                <button class="btn btn-info" value="${user.login.username}" data-bs-toggle="modal" data-bs-target="#exampleModal"><i class="fa fa-search" aria-hidden="true"></i></button>
                <button class="btn btn-warning" value="${user.login.username}" data-bs-toggle="modal" data-bs-target="#exampleModal2"><i class="fa fa-edit" aria-hidden="true"></i></button>
                <button class="btn btn-danger" value="${user.login.uuid}" ><i class="fa fa-trash" aria-hidden="true"></i></button>
            </td>
        </tr>
        `
        $(".dados").append(html);
               
        relatorio(response[0])
        //editarUsuario(response[0])
    })       
}

const relatorio = (usuario) => {
    console.log(usuario)
    const img= 'https://randomuser.me/api/portraits/women/75.jpg'
   
    let modal = 
        `
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="exampleModalLabel">${usuario.name.first} ${usuario.name.last}</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="imagem">
                        <img src="${usuario.picture.large}" alt="" srcset="">
                    </div>
                    <p>Titulo: ${usuario.name.title} </p>
                    <p>Nome: ${usuario.name.first} </p>
                    <p>Sobrenome: ${usuario.name.last}</p>
                    <hr>
                    <h3>Localização</h3>
                    <p>CEP: ${usuario.location.postcode}</p>
                    <p>Logradouro: ${usuario.location.street.name} - Nº ${usuario.location.street.number}</p>
                    <p>Cidade: ${usuario.location.city} - Estado: ${usuario.location.state} Pais: ${usuario.location.country}</p>
                    <hr>
                    <h4>Dados de Login</h4>
                    <h4>Login</h4>
                    <p>Usuário: ${usuario.login.username}</p>
                    <p>Senha: ${usuario.login.password}</p> 
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Fechar</button>
                </div>
                </div>
            </div>
       `
       
        $(".template-modal").append(modal);

    let modalEdit = 
        `
        <div class="modal fade" id="exampleModal2" tabindex="-1" aria-labelledby="exampleModalLabel2" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="exampleModalLabel2">${usuario.name.first} ${usuario.name.last}</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">

                    <form>                    
                        Nome<input type="text" class="form-group" name="firstname" id="firstname" value="${usuario.name.first}">
                    </form>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Fechar</button>
                    <button type="button" class="btn btn-primary">Salvar</button> 
                </div>
                </div>
            </div>
       `
       
        $(".template-modal").append(modalEdit);

        editarUsuario(usuario)

}

const editarUsuario = (usuario) => {
    $(".btn-primary").click(async function(e){       
        e.preventDefault;

        
        console.log(usuario)
        usuario.name.first = $("#firstname").val()

        $.ajax({
            type: "PATCH",
            url: "https://localhost:7112/User",
            data: JSON.stringify(usuario),
            dataType: 'application/json',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            success: function (response) {
               alert(response) 
            },
            error: function (jqXHR, textStatus, errorThrown) { 
                console.log(errorThrown)
                
            }
        }); 
        
        
    })
}

    
/*
"[
    {
        "gender":"female",
        "name":
            {"title":"Ms","first":"Tracey","last":"Williams"},
        "location": {"street":
                {"number":1520,"name":"Westmoreland Street"},
                "city":"Dublin",
                "state":"Longford",
                "country":"Ireland",
                "postcode":27936,
                "coordinates":{
                    "latitude":"0.5489",
                    "longitude":"53.8451"
                },
                "timezone":{
                    "offset":"+10:00",
                    "description":"Eastern Australia,
                    Guam, 
                    Vladivostok"
                    }
                },
                "email":"tracey.williams@example.com",
                "login":{
                    "uuid":"ffdf2f59-3c5c-4ca6-9adc-832ac206684d",
                    "username":"silverleopard293",
                    "password":"sixty9",
                    "salt":"XuXUMAgP",
                    "md5":"812268219c94c14cda0308afd95baa3c",
                    "sha1":"a5aa8edf67e7ccbb4b2d5927641322ddecacdece",
                    "sha256":"a984add07d38a7122844f4d3c2b8218fd80c6d8c0721fc66e2d2e219b823718b"
                },
                "dob":{
                    "date":"1953-03-16T22:22:58.468Z",
                    "age":71
                    },
                "registered":{
                    "date":"2015-01-25T08:38:11.420Z",
                    "age":9
                    },
                "phone":"021-044-5283",
                "cell":"081-567-7539",
                "id":{
                    "name":"PPS",
                    "value":"5460082T"
                },
                "picture":{
                   "large":"https://randomuser.me/api/portraits/women/75.jpg"
                   ,"medium":"https://randomuser.me/api/portraits/med/wome...

[{
                   */