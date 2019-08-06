# DameComida
Mobile App for tracking meals. 

Características versión previa. 
- No necesita conexión
- Optimizada para pantalla grande
- Sólo en español

Features
- CARGAR SEMANA. Carga la planificación de las comidas para una semana basándose en cinco tomas: Desayuno, Media Mañana, Almuerzo, Merienda y Cena
- SELECCIONAR SEMANA. Seleccionar un plan para seguirlo durante una semana. 
- QUÉ ME TOCA. Ver los alimentos de la siguiente comida. 
- LISTA DE LA COMPRA. Generar lista de la compra para la semana basándose en el plan cargado. 
- APUNTAR COMIDA. Registrar fácilmente las ingestas de los alimentos planificados a la hora que se haga o a la que se especifique, tanto si pertenecen al plan semanal o si no están asociados al mismo. 

Consideraciones para el diseño. 
- DietPlan. Contiene la planificación para los distintos días. 
- DietDay. Contiene la planificación para un día en concreto. 
- DietScheduledMeal. Contiene la planificación para una toma planificada. 
- Meal. Es una comida en concreto, que puede ser una lista de otros alimentos y tiene asociado un peso en gr. 

- PlanTracker. Contiene la planificación concreta a partir de un cierto día. 
  - DayTracker. Objeto para el seguimiento de un día en concreto. 
    - ScheduledMealTracker. Objeto para el seguimiento de una toma. 
    - FoodTracker. Asocia una toma espontánea en un día concreto. Se especifica el alimento y, opcionalmente, los gramos. 