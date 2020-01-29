# <a name="crud-avec-ef-core">CRUD avec Entity Framework Core</a>

<a href="https://docs.microsoft.com/fr-ca/ef/core/">Entity Framework (EF) Core</a> est une version légère, extensible, open source et multiplateforme de la très connue technologie d’accès aux données Entity Framework.
EF Core peut servir de mappeur relationnel/objet (O/RM), permettant aux développeurs .NET de travailler avec une base de données à l’aide d’objets .NET, et éliminant la nécessité de la plupart du code d’accès aux données qu’ils doivent généralement écrire. EF Core prend en charge de nombreux moteurs de base de données.

## <a name="objectif"></a> Objectif

Pour cette deuxième partie du laboratoire, les participants vont moodifier leur application pour intégrer la prise en charge de Entity Framework. Ils utiliseront ensuite 
les outils de Visual Studio pour mettre en place des formulaires permettant la consulation, l'ajout, la modification et la suppression des données dans une banque SQLite
en utilisant Entity Framework Core.

## <a name="open-web-site">Ouvrir le projet de demarrage</a>

1. Ouvrez Visual Studio, puis sélectionnez **Ouvrir un projet ou une solution**.

 ![Ouverture projet](./media/open-project.PNG)

2. Ouvrez la solution de l'étape 2 (\Etape 2 - Ajouter Entity Framewor Core\Workshop\Workshop.sln).

3. Supprimer le fichier **CommentairesController.cs** dans le dossier **Controllers**.

4. Supprimer le dossier **Commentaires** dans le dossier **Views**

# <a name="validation"></a> Validation avec les DataAnnotations

Les DataAnnotations sont utilisés pour personnaliser le modèle de données en utilisant des attributs qui spécifient des règles de mise en forme, de validation et de mappage de base de données.

Remplacez le contenu du fichier **Models\Commentaire.cs** par le code qui suit : 

```cs
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Commentaire
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        [Required]
        [Display(Name = "Adresse Mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Commemtaire")]
        public string Texte { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCommentaire { get; set; }
    }
}


```

L'attribut **Required** rend le champ obligatoire. 

L'attribut **Display** permet de définir le nom d'affichage.

L'attribut **DataType** permet de spécifier un type de données qui est plus spécifique que le type intrinsèque de la base de données.

L'attribut **DisplayFormat** permet de spécifier explicitement le format de la date.


# <a name="">Le DBContext</a>


```cs


```


# <a name=""></a>


# <a name=""></a>


# <a name=""></a>

```cs


```


```cs


```


```cs


```


```cs


```