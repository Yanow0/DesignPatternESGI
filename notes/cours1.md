# **Design Patterns en C#**

## **Cours 1**

**Définition Design Pattern** : Schéma d'objets permettant de répondre à un problème courant de conception en POO.

### **Patrons de conception**

- Abstract Factory :

    Une classe mère abstraite est une classe concrète qui va décrire la version du produit.

    Résout les problème liés à l'abstraction de classe dont on ne va pas connaitre la définition finale. Dérésponsabilise la classe mère.

    L'interface va permettre de définir la signature de chaque méthode.

    La signature de chaque méthode définit chaque produit du catalogue.

    On a une interface et des sous-classes pour chaque type de véhicule.

    La classe catalogue prend en parametre une instance d'une classe véhicule qui implémente l'interface Fabrique de véhicule.

  ![Diagramme Abstract Factory](img/abstractfactory.png)

  - Description Scooter : Scooter est une classe abstraite qui implémente Catalogue. ScooterElectricité et ScooterEssence héritent de Scooter et implémentent chacun une Fabrique différente.

- Builder : Problematique de base -> Construire des documents à la volée.

But : créer un constructeur de liasse de vehicules. Créer une liasse sans connaitre le type de documents en entrée.

- Factory method : On crée des objets dans une classe mère et le choix des types d’objets à créer est fait dans les sous classes.

- Singleton : Le pattern Singleton  permet de créer une instance et de la réutiliser dans l'application. Fournit une méthode de classe (statique) qui permet de retourner cette instance.
Le patron Abstract est susceptible d'utiliser ce type d'instance unique.

L'application va utiliser la classe liasse vierge (LiasseVierge) qui ne possodera qu'une seule instance.

  ![Liasse Vierge](img/Liassevierge.png)

Chaque classe qui utilise la liasse vierge doit avoir accès à la meme instance. On doit surtout s'arranger pour qu'on ne puisse pas en créer de nouvelles (avec l'opérateur new).

- Prototype : Permet de cloner des objets à partir d'autres objets appelés "prototypes" disposant d'une méthode Clone() qui retourne un objet identique.
