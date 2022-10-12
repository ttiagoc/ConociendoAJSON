// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    
    $("#button").click(function(){
        $.getJSON( "JSON_Restaurantes.json", function(res) {
            
            $.each( res, function( key, val ) {                 
                                             
                val.forEach(res => {
                    $('#Restaurante').append('<p>' + res.Nombre  + '</p>');
                    $('#AñoApertura').append('<p>' + res.Año_Apertura + '</p>');
                    $('#Dueño').append('<p>' + res.Dueño + '</p>');
                    $('#Ubicacion').append('<p>' + res.Ubicacion + '</p>');   
                    $('#Logo').append('<img src="' + res.Logo +'" alt="" style="max-width:60px; height:auto;"></img><br>');                        
                    $('#Menu').append('<p>' + res.MenuPrincipal[0].NombrePlato + '</p>');        
                    $('#Menu2').append('<p>' + res.MenuPrincipal[1].NombrePlato + '</p>');         
                    $('#Menu3').append('<p>' + res.MenuPrincipal[2].NombrePlato + '</p>');      
                    //$('#Reseñas').append('<button type="button" id="botonReseñas" class="btn btn-dark">Ver Reseñas</button> onclick="MostrarReseñas()"'); 
                          
                });     
                               
            });
        });
        $('#button').css("display","none");
    });