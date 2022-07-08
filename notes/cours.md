# **Design Patterns en C#**

**Définition Design Pattern** : Schéma d'objets permettant de répondre à un problème courant de conception en POO.

## **Patrons de construction**

- **Abstract Factory :**

    Une classe mère abstraite est une classe concrète qui va décrire la version du produit.

    Résout les problème liés à l'abstraction de classe dont on ne va pas connaitre la définition finale. Dérésponsabilise la classe mère.

    L'interface va permettre de définir la signature de chaque méthode.

    La signature de chaque méthode définit chaque produit du catalogue.

    On a une interface et des sous-classes pour chaque type de véhicule.

    La classe catalogue prend en parametre une instance d'une classe véhicule qui implémente l'interface Fabrique de véhicule.

  ![Diagramme Abstract Factory](img/abstractfactory.png)

  - **Description Scooter :** Scooter est une classe abstraite qui implémente Catalogue. ScooterElectricité et ScooterEssence héritent de Scooter et implémentent chacun une Fabrique différente.

- **Builder :** Problematique de base -> Construire des documents à la volée.

But : créer un constructeur de liasse de vehicules. Créer une liasse sans connaitre le type de documents en entrée.

- **Factory method :** On crée des objets dans une classe mère et le choix des types d’objets à créer est fait dans les sous classes.

- **Singleton :** Le pattern Singleton  permet de créer une instance et de la réutiliser dans l'application. Fournit une méthode de classe (statique) qui permet de retourner cette instance.
Le patron Abstract est susceptible d'utiliser ce type d'instance unique.

L'application va utiliser la classe liasse vierge (LiasseVierge) qui ne possodera qu'une seule instance.

  ![Liasse Vierge](img/Liassevierge.png)

Chaque classe qui utilise la liasse vierge doit avoir accès à la meme instance. On doit surtout s'arranger pour qu'on ne puisse pas en créer de nouvelles (avec l'opérateur new).

- **Prototype :** Permet de cloner des objets à partir d'autres objets appelés "prototypes" disposant d'une méthode Clone() qui retourne un objet identique.

## **Patrons de structuration**

**Définition** : Les patterns de structuration permettent de faciliter l'indépendance de l'interface d'un objet et de son implémentation.

En fournissant les interfaces ce pattern permet d'encapsuler la composition des objets.

Cela augmente le niveau d'abstraction d'un système donné, un peu à la manière des patterns de création qui encapsulent la création d'objets.

Ces patterns mettent en avant les interfaces.

### **Exercice : Composition vs Heritage en C#**

Composition : Une instance ou plusieurs instances de classes dans une autre. Permet aux différentes instances d'interagir ensemble.

> <https://itexpert.fr/blog/concepts-fondamentaux-poo/#composition>

Heritage : C’est le fait de baser la définition d’une classe (fille) sur une autre (mère), afin d’en récupérer les membres (champs et méthodes). L'héritage permet d’offrir une même interface de programmation pour des types différents.

> <https://itexpert.fr/blog/concepts-fondamentaux-poo/#h-ritage>

- **Adapter :** Le but de ce pattern est de convertir l'interface d'une classe donnée en une interface attendue en une interface attendue par des clients afin qu'ils puissent travailler ensemble.
En résumé, il permet de donner à une classe existante une nouvelle interface pour répondre aux besoins d'un client.

- **Bridge :** Le pattern Bridge est utilisé pour séparer le comportement de l'implémentation de l'interface et de l'implémentation de l'objet.

On s'interesse aux demandes d'immatriculation des véhicules.

Le formulaire de demande d'immatriculation possède deux implémentations différentes.

FormulaireImmat

FormulaireImmatHTML

FormulaireImmatAPP

Au départ le système a été conçu pour la France uniquement. Ensuite on a du créer une sous-classe FormulaireImmatCH. Elle aussi abstraite pour avoir également deux sous-classes concrètes (qui sont FormulaireImmatHTML et FormulaireImmatAPP dédiées à la Suisse).

Le pattern Bridge permet de créer une seul sous classe pour un nouveau pays sans recréer deux classes d'implémentation supplémentaire.

- **Composite :** Le pattern Composite offre un cadre de conception d'une composition d'objets dont on ne connaît pas  la profondeur. (On peut utiliser un arbre en tant qu'analogie).

Les "clients" interagissent avec les objets sans connaître la structure de l'arbre.

- **Decorator :** Le pattern Decorator permet d'ajouter **dynamiquement** des fonctionnalités **supplémentaires** à un objet sans modifier l'interface de l'objet (les clients de l'objet ne sont pas au courant de la modification).
Il s'agit d'une alternative à la création d'une sous-classe qui permettrait d'enrichir l'objet.

## **Patrons de comportement**

Leur but est de distribuer des traitements/algorithmes entre les objets.

Ils organisent les interactions en renseignant le "flux de controle" et de traitement au sein d'un système d'objets.

La distribution se fait soit par héritage soit par "délégation".

- **Chain of responsibility :** Le pattern Chain of responsibility permet de construire une chaîne d'objets de manière à ce que si un objet de la chaîne ne peut répondre à une requête, il puisse la passer à un "successeur" et ainsi de suite jusqu'à ce qu'un objet puisse y répondre.

- **Command :** Ce pattern transforme une requête en objet, ceci facilite les opérations relatives à la requête. Ex : Annulation, queue, suivi, etc.
