SELECT * FROM WEB001Xe

SELECT * FROM WEB006X

UPDATE WEB001X SET COMX_IMG = 
(SELECT COM_IMG from Soporte1.soporte1.WEB001 WHERE COM_NRO = 4035)
WHERE COMX_ID = 2

SELECT COMX_AUT FROM WEB001X WHERE COMX_ID = 2
UPDATE WEB001X SET COMX_AUT = 'MSCHABERGE' WHERE COMX_ID = 2

UPDATE WEB001X SET COMX_DES = 
'Este debe ser un titulo de 255 caracteres. Se realiza esta prueba para ver como se visualiza el título largo en la comunicación y así evitar que quede feo, visiblemente hablando. Sigo  escribiendo para que el título llegue a 255 caracteres. Y así alcanza.'
--'Prueba de comunicación privada.'
 WHERE COMX_ID = 2
 
 
 
 UPDATE WEB001X SET COMX_COP = 
 'Gustavo Adrián Cerati Clark (Barracas, Ciudad de Buenos Aires, 11 de agosto de 1959)4 es un músico, cantautor, compositor y productor discográfico argentino, considerado uno de los más influyentes y reconocidos músicos del rock iberoamericano y una leyenda del rock argentino.5 6 7 8
Obtuvo fama y reconocimiento internacional por haber sido el vocalista, guitarrista y compositor principal de la banda de rock Soda Stereo, una de las bandas más importantes e influyentes de la música latina. '
 WHERE COMX_ID = 2
 
 
 UPDATE WEB001X SET COMX_BRE = 
 'Nació el 11 de agosto de 1959 en Buenos Aires, capital de Argentina, hijo mayor del ingeniero y contador Juan José Cerati y Lilian Clark.10 Desde chico estuvo ligado al ambiente musical. Su primera incursión fue en un grupo de palos de escoba que formó en la primaria, donde se destacó frente a los demás alumnos. Además de la música, tenía otros pasatiempos: dibujaba durante largos ratos, creando personajes de cómics, como "Supercerebro", parecido a Superman, pero con la peculiaridad de que la kriptonita no le hacía nada, solo los médiums llegaban a afectarlo, sin poder sentir. Hábil para los deportes (practicaba natación y atletismo), obtuvo un segundo lugar en un certamen de la revista Billiken, tras correr los 100 metros en una competición intercolegial. Una de de las actividades fundamentales que realizó durante esos primeros años consistió en dirigir el coro del colegio Instituto San Roque, donde más tarde debió cumplir con una suspensión por eructar durante una celebración de misa (Pudo volver a su cargo luego de ganar un premio de canto en el Coliseo y donarlo a la institución). Sus primeras influencias musicales fueron grupos como The Police (A quienes ofrece un tributo de la canción Bring On The Night, donde él canta y toca el bajo, junto a Andy Summers, en la guitarra y Vinnie Colaiuta en la batería), Queen (graba un cover deSome Day One Day con Soda Stereo llamado "Algún día") y The Cure. También David Bowie, Luis Alberto Spinetta, Brian May deQueen y Ritchie Blackmore de Deep Purple. En la secundaria formó los grupos con la que ganó un concurso de canción navideña en Canal 9. Luego formó dos bandas simultáneas, "Savage", de rock y blues, y "Vozarrón" de música de fusión. Savage estaba integrada también por dos cantantes inglesas y solía actuar en un cabaret frente al Parque Centenario. También formó un trío llamado "Triciclo".11 En el verano de 1982 tocó junto a Zeta Bosio y Sandra Baylac con la banda The Morgan en Punta del Este.'
 WHERE COMX_ID = 2
 
 select * from WEB001Xa WHERE COMX_ID = 2 AND COMXa_FBA IS NULL