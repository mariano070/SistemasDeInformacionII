SELECT * FROM WEB001Xe

SELECT * FROM WEB006X

UPDATE WEB001X SET COMX_IMG = 
(SELECT COM_IMG from Soporte1.soporte1.WEB001 WHERE COM_NRO = 4035)
WHERE COMX_ID = 2

SELECT COMX_AUT FROM WEB001X WHERE COMX_ID = 2
UPDATE WEB001X SET COMX_AUT = 'MSCHABERGE' WHERE COMX_ID = 2

UPDATE WEB001X SET COMX_DES = 
'Este debe ser un titulo de 255 caracteres. Se realiza esta prueba para ver como se visualiza el t�tulo largo en la comunicaci�n y as� evitar que quede feo, visiblemente hablando. Sigo  escribiendo para que el t�tulo llegue a 255 caracteres. Y as� alcanza.'
--'Prueba de comunicaci�n privada.'
 WHERE COMX_ID = 2
 
 
 
 UPDATE WEB001X SET COMX_COP = 
 'Gustavo Adri�n Cerati Clark (Barracas, Ciudad de Buenos Aires, 11 de agosto de 1959)4 es un m�sico, cantautor, compositor y productor discogr�fico argentino, considerado uno de los m�s influyentes y reconocidos m�sicos del rock iberoamericano y una leyenda del rock argentino.5 6 7 8
Obtuvo fama y reconocimiento internacional por haber sido el vocalista, guitarrista y compositor principal de la banda de rock Soda Stereo, una de las bandas m�s importantes e influyentes de la m�sica latina. '
 WHERE COMX_ID = 2
 
 
 UPDATE WEB001X SET COMX_BRE = 
 'Naci� el 11 de agosto de�1959�en�Buenos Aires, capital de�Argentina, hijo mayor del ingeniero y contador Juan Jos� Cerati y Lilian Clark.10�Desde chico estuvo ligado al ambiente musical. Su primera incursi�n fue en un grupo de palos de escoba que form� en la primaria, donde se destac� frente a los dem�s alumnos. Adem�s de la m�sica, ten�a otros pasatiempos: dibujaba durante largos ratos, creando personajes de c�mics, como "Supercerebro", parecido a�Superman, pero con la peculiaridad de que la kriptonita no le hac�a nada, solo los m�diums llegaban a afectarlo, sin poder sentir. H�bil para los deportes (practicaba nataci�n y atletismo), obtuvo un segundo lugar en un certamen de la revista�Billiken, tras correr los 100 metros en una competici�n intercolegial. Una de de las actividades fundamentales que realiz� durante esos primeros a�os consisti� en dirigir el coro del colegio�Instituto San Roque, donde m�s tarde debi� cumplir con una suspensi�n por eructar durante una celebraci�n de misa (Pudo volver a su cargo luego de ganar un premio de canto en el Coliseo y donarlo a la instituci�n). Sus primeras influencias musicales fueron grupos como�The Police�(A quienes ofrece un tributo de la canci�n Bring On The Night, donde �l canta y toca el bajo, junto a�Andy Summers, en la guitarra y�Vinnie Colaiuta�en la bater�a),�Queen�(graba un cover deSome Day One Day�con�Soda Stereo�llamado "Alg�n d�a") y�The Cure. Tambi�n�David Bowie,�Luis Alberto Spinetta,�Brian May�deQueen�y�Ritchie Blackmore�de�Deep Purple. En la secundaria form� los grupos con la que gan� un concurso de canci�n navide�a en�Canal 9. Luego form� dos bandas simult�neas,�"Savage", de rock y blues, y�"Vozarr�n"�de m�sica de fusi�n.�Savage�estaba integrada tambi�n por dos cantantes inglesas y sol�a actuar en un cabaret frente al�Parque Centenario. Tambi�n form� un tr�o llamado�"Triciclo".11 En el verano de 1982 toc� junto a�Zeta Bosio�y�Sandra Baylac�con la banda�The Morgan�en�Punta del Este.'
 WHERE COMX_ID = 2
 
 select * from WEB001Xa WHERE COMX_ID = 2 AND COMXa_FBA IS NULL