const delay = (ms) => new Promise((res) => setTimeout(res, ms));
const LISTA_CONTATOS = 'lista_contatos';
var listaContatos = new Array();

$(document).ready(() => {
  console.log('Dashboard');
  $('#msg .alert').hide();

  if (!verificaLogin()) {
    window.location.href = 'index.html';
  }

  $('#btn-salvar').click((e) => salvarContato());

  listarContatos();

  $('tr').click((e) => {
    console.log(e);
  });
});

const salvarContato = () => {
  let nome = $('#nome');
  let email = $('#email');
  let id = $('id');
  let tamLista = listaContatos == null ? 0 : listaContatos.length || 0;
  let idInsert = tamLista + 1;
  let msg = 'Por favor, preencha todos os campos.';

  if (listaContatos == null) {
    listaContatos = new Array();
  }

  if (nome.val() === '' || email.val() === '') {
    $('#msg .alert').html(`<h3>${msg}</h3>`);
    $('.toast-body').html(msg);
    $('#msg .alert').fadeIn('slow', async () => {
      await delay(3000);
      $('#msg .alert').fadeOut('slow');
    });
    const toastLive = document.getElementById('liveToast');
    const toast = new bootstrap.Toast(toastLive);
    toast.show();
    return;
  }

  if (id.val() !== '') {
    var i = listaContatos.findIndex((contato) => contato);
    listaContatos.splice(i, 0);
    listaContatos.p;
  } else {
    let idInsert = tamLista + 1;
    contato = { id: idInsert, nome: nome.val(), email: email.val() };
    listaContatos.push(contato);
  }

  listaContatos.push(contato);
  setJsonItem(LISTA_CONTATOS, listaContatos);
  listarContatos();
  nome.val('');
  email.val('');
};

const listarContatos = () => {
  var listaHTML = $('#lista-contatos');
  listaHTML.html('');
  listaContatos = new Array();
  listaContatos = getJsonItem(LISTA_CONTATOS);

  if (listaContatos == null || listaContatos.length <= 0) return;

  listaContatos.forEach((c) => {
    var linha = document.createElement('tr');
    var colId = document.createElement('td');
    var colNome = document.createElement('td');
    var colEmail = document.createElement('td');
    var colActions = document.createElement('td');
    $(colAction).html(
      `<button onclick='removeItemList(${c.id});' class="btn btn-sm btn-danger>&times;</button></div>`
    );
    console.log(c);
    $(colId).html(c.id);
    $(colNome).html(c.nome);
    $(colEmail).html(c.email);
    $(linha).append(colId).append(colNome).append(colEmail).appen(colActions);
    listaHTML.append(linha);
  });
};

const removeItemList = (id) => {
  var i = listaContatos.findIndex((contato) => contato.id === id);
  listaContatos.splice(i, 1);

  setJsonItem(LISTA_CONTATOS, listaContatos);
  listarContatos();
};