# Desarrollo de la práctica

## Script "PlayerController.cs"

Para desarrollar este script no tuve grandes dificultades, ya que pude basarme en actividades previas realizadas en clase. La única parte que tuve que consultar externamente fue el uso de `tags`, ya que no encontraba la opción necesaria para implementar correctamente la detección del suelo (`ground`).

Como **funcionalidad opcional**, implementé que el personaje rotase en la dirección del movimiento. Inicialmente tuve problemas porque al establecer la cámara como objeto hijo del jugador, las referencias de movimiento se calculaban respecto al mundo y no respecto al propio personaje. Finalmente opté por una vista en tercera persona desde arriba y separé la lógica en otro script para que la cámara siguiera al personaje desde atrás.

Otra **funcionalidad opcional** fue limitar el salto a un máximo de dos consecutivos. Para ello utilicé un contador que se incrementa al saltar y se reinicia al tocar el suelo, controlándolo mediante una estructura condicional.


## Script "Camara.cs"

Creé un script independiente para que la cámara siguiera al jugador manteniendo una posición ligeramente elevada y desplazada hacia atrás. La posición se actualiza continuamente en función del jugador.

Esta solución surgió tras comentar el problema con algunos compañeros y resultó más sencilla de implementar de lo que esperaba.


## Script "PlatformMovement.cs"

Este apartado fue el más complejo. Aunque seguí las indicaciones dadas en clase, surgieron varios errores relacionados con la gestión del punto de destino y la referencia entre el objeto plataforma y el objeto objetivo.

Una vez comprendida correctamente la relación entre ambos y ajustadas las referencias, el comportamiento funcionó correctamente.


## Script "FallingPlatform.cs"

Intenté implementar esta funcionalidad, pero no conseguí plantear correctamente la lógica para que la plataforma comenzara a caer al ser tocada por el jugador.
