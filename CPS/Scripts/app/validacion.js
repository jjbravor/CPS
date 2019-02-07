//**********************************************************************************************//
//Nombre Archivo: 	validacion.js								//
//Lenguaje: 		Java Script								//
//Creado por: 		Miguel Roman								//
//Fecha Creación:	29/11/2008								//
//Descripción:		Validaciones 			 					//
//**********************************************************************************************//


//**********************************************************************************************//
//	VARIABLES                               						//
//**********************************************************************************************//
var defaultEmptyOK 		= false
var Caracteres_Letras 		= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ._-() "
var Caracteres_Numeros 		= "0123456789"
var Caracteres_Decimal 		= "0123456789."
var Caracteres_Telefono 	= "0123456789()-+ext. EXT"
var Caracteres_Rut  		= "0123456789Kk-"
var Caracteres_Identidad	= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-"
var Caracteres_Email 		= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ._0123456789-@;"
var Caracteres_Especiales 	= "áéíóúñÁÉÍÓÚÑ#-"
var Caracteres_Password         = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ª°|@!¡#$%&()_*/:;,.<>=+{}¿?" //"\-[]
var Caracteres_Batch     	= "0123456789.:-stST"
				
				
var Espacios      		= " \t\n\r"
				
var Caracteres   		= "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZÁÉÍÓÚÑabcdefghijklmnopqrstuvwxyzáéíóúñü\\#$%()/*+-._ "





//**********************************************************************************************//
//Descripción:		Es Vacio		 						//
//Parámetros Entrada:	String									//
//												//
//Parametros Salida:	String Vacio o Nulo							//
//												//
//**********************************************************************************************//
function es_Empty(s)
{   
	s==null;
	return (s)
}





//**********************************************************************************************//
//Descripción:		Quita todos los caracteres que estan en bag del string s		//
//Parámetros Entrada:	String									//
//												//
//Parametros Salida:	String									//
//												//
//**********************************************************************************************//
function stripCharsInBag (s, bag)
{   
	var i;
    	var returnString = "";
   
    	for (i = 0; i < s.length; i++)
    	{   
    		var c = s.charAt(i);
    		if (bag.indexOf(c) == -1) returnString += c;
    	}
    	return returnString
}






//**********************************************************************************************//
//Descripción:		Quita todos los caracteres que no estan en bag del string s		//
//Parámetros Entrada:	String									//
//												//
//Parametros Salida:	String									//
//												//
//**********************************************************************************************//
function stripCharsNotInBag (s, bag)
{   
	var i;
    	var returnString = "";
    
    	for (i = 0; i < s.length; i++)
    	{   
        	var c = s.charAt(i);
        	if (bag.indexOf(c) != -1) returnString += c;
    	}    	
    	return returnString
}





//**********************************************************************************************//
//Descripción:		Quita todos espacios en blanco de un string				//
//Parámetros Entrada:	String									//
//												//
//Parametros Salida:	String									//
//												//
//**********************************************************************************************//
function stripWhitespace (s)
{   
	return stripCharsInBag (s, Espacios)
}





//**********************************************************************************************//
//Descripción:		Quita todos espacios que anteceden al string				//
//Parámetros Entrada:	String									//
//												//
//Parametros Salida:	String									//
//												//
//**********************************************************************************************//
function stripInitialWhitespace (s)
{   
	var i = 0;
    	while ((i < s.length) && charInString (s.charAt(i), Espacios))
       		i++;
    	return s.substring (i, s.length);
}


//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Password       				//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Password (c)
{   
	return (stripCharsNotInBag (c, Caracteres_Password))	
}



//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Letras						//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Letra (c)
{   
	return (stripCharsNotInBag (c, Caracteres_Letras))	
}





//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Numeros					//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Numero (c)
{   
	return (stripCharsNotInBag (c, Caracteres_Numeros))	
		
}





//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Decimal					//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Decimal (c)
{   
	return (stripCharsNotInBag (c, Caracteres_Decimal))	
}





//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Letra o Numero					//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Letra_Numero (c)
{   
	return (es_Letra(c) || es_Numero(c))
}





//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Telefono					//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Telefono (c) 
{   
	return (stripCharsNotInBag (c, Caracteres_Telefono ))	    	
}


//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Email					//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Email (c) 
{   
	return (stripCharsNotInBag (c, Caracteres_Email ))	    	
}

//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Batch						//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Batch (c) 
{   
	return (stripCharsNotInBag (c, Caracteres_Batch ))	    	
}

//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Rut						//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Rut (c) 
{   
	return (stripCharsNotInBag (c, Caracteres_Rut ))	    	
}


//**********************************************************************************************//
//Descripción:		Valida si es Caracter de Identidad					//
//Parámetros Entrada:	Caracter								//
//												//
//Parametros Salida:	Caracter								//
//												//
//**********************************************************************************************//
function es_Identidad (c) 
{   
	return (stripCharsNotInBag (c, Caracteres_Identidad ))	    	
}


//**********************************************************************************************//
//Descripción:		Valida un RUT								//
//Parámetros Entrada:	cc_rut									//
//												//
//Parametros Salida:	True o False								//
//												//
//**********************************************************************************************//
function RutVerificador(cc_rut) 
{
	var factor = 2;
	var suma = 0;
	
	var pos = cc_rut.indexOf("-");
	if( pos == -1 )
	{		
		return false;
	}

	var valRut = cc_rut.substring(0,pos);
	var digito = cc_rut.substring(pos+1,cc_rut.length);
		
	// Valida Si después del "-" colocó más caracteres....
	if ( digito.length > 1  ) 
	{		
		return false;
	}
	
	for( var i = valRut.length-1; i >= 0; i -= 1)
	{
		var ch = valRut.substring(i, i + 1);
		if (ch < "0" || ch > "9")
		{			
			return false;
		}
		suma = parseInt(ch) * factor + suma;
		factor = factor + 1;
		if( factor == 8)
		{
			factor = 2;
		}
	}
	suma = suma % 11;
	suma = 11 - suma;
	if( suma == 11 )
	{
		suma = 0;
	}
	if( suma == 10 && ( digito == "k" || digito == "K" ))
	{
		return true;
	}
	else if( suma == parseInt(digito) )
	{
		return true;
	}
	return false;
}





//**********************************************************************************************//
//Descripción:		Reemplaza un caracter por otro						//
//Parámetros Entrada:	String									//
//												//
//Parametros Salida:	String									//
//												//
//**********************************************************************************************//
function replace(entry,out,add)
{
	if (!(out==""))
	{
		temp = "" + entry;
		while (temp.indexOf(out)>-1) 
		{
			pos= temp.indexOf(out);
			temp = "" + (temp.substring(0, pos) + add + temp.substring((pos + out.length), temp.length));
		}
	}	
	return(temp);
}

//****************************+

function Asociar() 
   { 
    if (confirm('¿Acepta Términos y Condiciones del Servicio?')) 
        return true; 
    else 
        {
        if (confirm('¿Acepta Términos y Condiciones del Servicio?')) 
            return false;
            
        }
       
  } 
  
  
  //****************************
  
 

