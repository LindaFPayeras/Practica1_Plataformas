# Desarrollo de la práctica

## Práctica 1

### Script "PlayerController.cs"

Para desarrollar este script no tuve grandes dificultades, ya que pude basarme en actividades previas realizadas en clase. La única parte que tuve que consultar externamente fue el uso de `tags`, ya que no encontraba la opción necesaria para implementar correctamente la detección del suelo (`ground`).

Como **funcionalidad opcional**, implementé que el personaje rotase en la dirección del movimiento. Inicialmente tuve problemas porque al establecer la cámara como objeto hijo del jugador, las referencias de movimiento se calculaban respecto al mundo y no respecto al propio personaje. Finalmente opté por una vista en tercera persona desde arriba y separé la lógica en otro script para que la cámara siguiera al personaje desde atrás.

Otra **funcionalidad opcional** fue limitar el salto a un máximo de dos consecutivos. Para ello utilicé un contador que se incrementa al saltar y se reinicia al tocar el suelo, controlándolo mediante una estructura condicional.


### Script "Camara.cs"

Creé un script independiente para que la cámara siguiera al jugador manteniendo una posición ligeramente elevada y desplazada hacia atrás. La posición se actualiza continuamente en función del jugador.

Esta solución surgió tras comentar el problema con algunos compañeros y resultó más sencilla de implementar de lo que esperaba.


### Script "PlatformMovement.cs"

Este apartado fue el más complejo. Aunque seguí las indicaciones dadas en clase, surgieron varios errores relacionados con la gestión del punto de destino y la referencia entre el objeto plataforma y el objeto objetivo.

Una vez comprendida correctamente la relación entre ambos y ajustadas las referencias, el comportamiento funcionó correctamente.


### Script "FallingPlatform.cs"

Intenté implementar esta funcionalidad, pero no conseguí plantear correctamente la lógica para que la plataforma comenzara a caer al ser tocada por el jugador.

## Práctica 2
### Arreglos de la Práctica 1
He creado una plataforma que se cae y he arreglado los prefabs para que sean prefabs de verdad.

### Coleccionables y enemigos

Para hacer esto use monedas como coleccionables y pinchos en las plataformas que hacen que bajes de vidas. Tienen más o menos el mismo funcionamiento llamando a sumar o restar coleccionables o vidas. 

### Modificaciones en el Player

Se añade el respawn, pensé en hacer simplemente `transform.position = Vector3.zero` pero no me acabó convenciendo dado que no empezaba desde el 0 como tal, así que se quedó así que me parece más específico.

### Escenas
- Inicio
- Juego
- Victoria
- GameOver

GameOver y Victoria son bastante parecidas, con ligeros cambios y salen cuando se acaban las vidas o consigues 3 monedas respectivamente. 

En vez de llegar a un sitio, tal como están puestas las plataformas en mi juego, conseguir 3 me parecía lo más coherente. 

Para conseguirlo he tenido que hacer un arreglo un poco sucio, pero funcional. En la siguiente lo intentaré arreglar. 

