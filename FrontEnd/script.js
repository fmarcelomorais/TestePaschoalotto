$(document).ready(async function () {
    listaDeUsuarios();
    criaUsuario();
   
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

async function getUsuarios(){
    const request = await fetch("https://localhost:7112/User");
    const response = await request.json();
    return response
}


async function listaDeUsuarios(){
    
    const usuarios = await getUsuarios()
    let html = ''
    usuarios.map((user, id) => {
        
        html +=
        `
        <tr > 
            <td scope="row">${user.name.first}</td>
            <td scope="row">${user.name.last}</td>
            <td>
                <button class="btn btn-info" id="ver${id}" value="${id}" data-bs-toggle="modal" data-bs-target="#exampleModal"> 
                    <i class="fa fa-search" aria-hidden="true"></i>
                </button>
                    <button class="btn btn-warning" id="ver${id}" value="${id}" data-bs-toggle="modal" data-bs-target="#exampleModal">
                        <i class="fa fa-edit" aria-hidden="true"></i>
                    </button>
                    <button class="btn btn-danger" ><i class="fa fa-trash" aria-hidden="true"></i></button>
                </td>
            </tr>    
        `
    });

    $(".dados").append(html)
    relatorio()
    editar()

}

async function relatorio(){
    const usuarios = await getUsuarios()

    let listabtn = $(".btn-info") 

    const $modal = document.querySelector(".modal-dialog")

    let modal = ''
    usuarios.map((usuario, i)=>{
        $(listabtn[i]).click(function (e) { 
            e.preventDefault();            
            
                modal = ` <div class="modal-content">
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
                    </div>`
                    $modal.innerHTML = modal        
        });
    })
} 

async function editar(){
    const usuarios = await getUsuarios()

    let listabtn = $(".btn-warning") 

    const $modal = document.querySelector(".modal-dialog")

    let modal = ''
    usuarios.map((usuario, i)=> {
        $(listabtn[i]).click(function (e) { 
            e.preventDefault();
            modal = `
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
           `
           $modal.innerHTML = modal 

           editarUsuario(usuario)
        })
    })
    
}
async function editarUsuario (usuario) {
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
