function Pessoa(primeiro,ultimo) {
	this.primeiro = primeiro
	this.ultimo = ultimo

	this.nomeCompleto = function() {
		return this.primeiro + ' ' + this.ultimo
	}

	this.nomeCompletoInvertido = function() {
		return this.ultimo + ' ' + this.primeiro
	}
}

var chefe = new Pessoa('Bruno','Ruas')

console.log(chefe.nomeCompleto())
console.log(chefe.nomeCompletoInvertido())
