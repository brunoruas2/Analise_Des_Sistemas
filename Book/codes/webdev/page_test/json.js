// JSON em string
var TextoJSON = `{"Revistas": [
    {
        "titulo":"V de Vingança",
        "autor":"Frank Miller"
    },
    {
        "titulo":"Batman - The Dark Knight",
        "autor":"Frank Miller"
    },
    {
        "titulo":"One Piece Nº 29",
        "autor":"Eichiro Oda"
    }
]}`

// Usando o metodo de parse do JSON
var banca = JSON.parse(TextoJSON)

function listaTitulos() {
    lista = ''
    for (let i = 0; i < banca.Revistas.length; i++) {
        lista += banca.Revistas[i].titulo + ' - ' +
        banca.Revistas[i].autor + '\n'
    }
    console.log(lista)
}

listaTitulos()

console.log(JSON.stringify(banca,null,2))