$(document).ready(function () {


    $('#submit').click(function () {
        var date = new Date($('#date-input').val());
        date.setDate(date.getDate());
        var anoB = false;
        var day = String(date.getDate());
        var month = String(date.getMonth() + 1);
        var year = String(date.getFullYear());

        //converter as variaveis para inteiros
        var dia = parseInt(day);
        var mes = parseInt(month);
        var ano = parseInt(year);
		
        while (dia > 0 & mes > 0 & ano > 0) {

            if (ano % 4 == 0) {
                anoB = true;
            }
            else if (ano % 100 == 0) {
                anoB = false;
            } else if (ano % 400 == 0) {
                anoB = true;
            }

            //meses que acabam em 31
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10) {
                if (dia < 31) {
                    dia = dia + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }

                if (dia == 31) {
                    dia = 1;
                    mes = mes + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }
            }

            //meses que acabam em 30
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
                if (dia < 30) {
                    dia = dia + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }

                if (dia == 30) {
                    dia = 1;
                    mes = mes + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }
            }

            //dezembro
            if (mes == 12) {
                if (dia < 31) {
                    dia = dia + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }

                if (dia == 31) {
                    dia = 1;
                    mes = 1;
                    ano = ano + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }
            }

            //fevereiro
            if (mes == 2 & anoB == true) {
                if (dia < 29) {
                    dia = dia + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
					anoB = false;
                    break;
                }

                if (dia == 29) {
                    dia = 1;
                    mes = mes + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
					anoB = false;
                    break;
                }
            }

            if (mes == 2 & anoB == false) {
                if (dia < 28) {
                    dia = dia + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }

                if (dia == 28) {
                    dia = 1;
                    mes = mes + 1;
                    document.getElementById('resultado').innerHTML = [dia, mes, ano].join('/');
                    break;
                }
            }
        }

    });

});


//recursivo
function factorial(n) {
    if (n == 1) {
        return 1;
    }

    return n * factorial(n - 1);
}

function calcularfatorial() {
    var input = document.getElementById('num1').value;
    var result = factorial(input);

    document.getElementById('resultadofatorial').innerHTML = result;
}


//nao recursivo
function factorial2(num) {
    var result;
    var num = document.getElementById('num1').value;

    if (num === 0 || num === 1)
        result = 1;

    for (var i = num - 1; i >= 1; i--) {

        num = num * i;
        result = num;
    }

    document.getElementById('resultadofatorial').innerHTML = result;
}
