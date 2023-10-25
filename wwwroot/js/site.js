function MostrarTemporadas(idSerie){
    $.ajax(
        {
            type:'POST',
            dataType:'JSON',
            url:'/Home/ListarTemporadas',
            data:{IdS:idSerie},
            success:
            function(response){

                let temporadas=[];
                for (const temp of response) {
                   temporadas.push("<li>"+temp.numeroTemporada+"- "+temp.tituloTemporada+"</li>");

                }

                $("#Titulo__Modal").html("Temporadas");
                $("#Contenido__Modal").html(temporadas);

            }
        }
    )
}


function MostrarActores(idSerie){
    $.ajax(
        {
            type:'POST',
            dataType:'JSON',
            url:'/Home/ListarActores',
            data:{IdS:idSerie},
            success:
            function(response){

                let actores=[];
                for (const act of response) {
                   actores.push("<li>"+act.nombre+"</li>");

                }
                $("#Titulo__Modal").html("Actores");
                $("#Contenido__Modal").html(actores);
            }
        }
    )
}

function MostrarInfo(idSerie){
    $.ajax(
        {
            type:'POST',
            dataType:'text',
            url:'/Home/TraerSerie',
            data:{IdS:idSerie},
            success:
            function(response){
                console.log("x");
                $("#Titulo__Modal").html("Sinopsis");
                $("#Contenido__Modal").html("<p>" + response + "</p>");
            }
        }
    )
}