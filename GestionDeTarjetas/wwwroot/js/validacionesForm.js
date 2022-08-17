window.addEventListener("load", function () {
    const formDate = document.getElementById('formIndex');
    const inputPresentacion = document.getElementById('Presentacion');
    const inputDesde = document.getElementById('Desde');
    const inputHasta = document.getElementById('Hasta');
    const boton_excel = document.getElementById('grabar_excel');
    const boton_txt = document.getElementById('grabar_txt');


    function showErrorMessage(elemento, mensaje) {
        elemento.innerHTML = '<p>' + mensaje + '</p>';
        elemento.style.color = 'red';
    };


    function validacionPresentacion() {

        let contenedorFecha = document.getElementById('error-fecha-presentacion');
        contenedorFecha.innerHTML = '';


        if (!inputPresentacion.value) {
            showErrorMessage(contenedorFecha, 'Seleccioná una fecha, por favor.')
            return true
        } else {
            contenedorFecha.innerHTML = '';
            return false
        }

    }

    function validarFechaDesde() {
        let contenedorFechaDesde = document.getElementById('error-fecha-desde');        
        contenedorFechaDesde.innerHTML = "";        

        if (!inputDesde.value) {
            showErrorMessage(contenedorFechaDesde, 'Seleccioná una fecha, por favor.')
            return true
        } else {
            contenedorFechaDesde.innerHTML = '';
            contenedorFechaDesde.style.color = '';
            return false
        }
    }

    function validarFechaHasta() {
        let contenedorFechaHasta = document.getElementById('error-fecha-hasta');
        if (!inputHasta.value) {

            showErrorMessage(contenedorFechaHasta, 'Seleccioná una fecha, por favor.')
            return true
        } else {

            let arrDesde = inputDesde.value.split("-");
            let arrHasta = inputHasta.value.split("-");

            if (arrHasta[1] < arrDesde[1] || arrHasta[0] < arrDesde[0] || arrHasta[2] < arrDesde[2]) {

                showErrorMessage(contenedorFechaHasta, 'La fecha Hasta no puede ser menor a la fecha Desde.')
                return true
            } else {
               
                contenedorFechaHasta.innerHTML = '';
                contenedorFechaHasta.style.color = '';
                return false
            }
        }
    }

    boton_excel.addEventListener('click', function (e) {
        let errors = {
            inputPresentacion: validacionPresentacion(),
            inputDesde: validarFechaDesde(),
            inputHasta: validarFechaHasta()
        }
        if (errors.inputPresentacion || errors.inputDesde || errors.inputHasta)
            e.preventDefault();
        else {
            formDate.submit();
        }
    })

    boton_txt.addEventListener('click', function (e) {
        let errors = {
            inputPresentacion: validacionPresentacion(),
            inputDesde: validarFechaDesde(),
            inputHasta: validarFechaHasta()
        }
        if (errors.inputPresentacion || errors.inputDesde || errors.inputHasta)
            e.preventDefault()
        else {
            formDate.submit();
        }
    })


    inputPresentacion.addEventListener('blur', validacionPresentacion);
    inputDesde.addEventListener('blur', validarFechaDesde);
    inputHasta.addEventListener('blur', validarFechaHasta);
})