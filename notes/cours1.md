# **Design Patterns en C#**

## Cours 1

**Définition Design Pattern** : Schéma d'objets permettant de répondre à un problème courant de conception en POO.

Patron de construction

- Abstract Factory :

    Une classe mère abstraite est une classe concrète qui va décrire la version du produit.

    Résout les problème liés à l'abstraction de classe dont on ne va pas connaitre la définition finale. Dérésponsabilise la classe mère.

    L'interface va permettre de définir la signature de chaque méthode.

    La signature de chaque méthode définit chaque produit du catalogue.

    On a une interface et des sous-classes pour chaque type de véhicule.

    La classe catalogue prend en parametre une instance d'une classe véhicule qui implémente l'interface Fabrique de véhicule.

  ![Diagramme Abstract Factory](img/abstractfactory.png)

  - Description Scooter : Scooter est une classe abstraite qui implémente Catalogue. ScooterElectricité et ScooterEssence héritent de Scooter et implémentent chacun une Fabrique différente. 