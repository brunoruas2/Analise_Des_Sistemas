// Função que recebe um input no terminal
const readLine = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
})

readLine.question('Qual seu nome? ', name => {
    switch (name) {
        case 'bruno':
            console.log(`OI, BRUNO!`)
            break
    
        case 'mario':
            console.log('Salve, Mario!')
            break
        
        default:
            console.log(`Olá, ${name}. Seja bem-vindo(a)!`)
    }
    readLine.close()
})

