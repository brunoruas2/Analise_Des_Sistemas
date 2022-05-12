// usando 'this' em uma arrow function
var Pessoa2 = {
    nome:'Bruno',
    amigos: ['Ana','Clarck','Bruce'],

    exibeAmigos() {
        this.amigos.forEach(f => console.log(this.nome + ' é amigo de ' + f))
    }
}

Pessoa2.exibeAmigos()