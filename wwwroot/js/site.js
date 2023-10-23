function MostrarTemporadas(idSerie){
    $.ajax(
        {
            type:'POST',
            dataType:'JSON',
            url:'/Home/ListarTemporadas',
            data:{IdS:idSerie},
            success:
            function(response){
                for (const temp in response) {
                  $("#listaTemporadas").html("<li>"+temp.NumeroTemporada+"- "+temp.TituloTemporada+"</li>");
                }
                console.log("x");

            }
        }
    )
}