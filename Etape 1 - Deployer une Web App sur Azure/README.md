
# <a name="create-an-aspnet-core-web-app-in-azure"></a>Créer et déployer une application web ASP.NET Core dans Azure Web Apps


[Azure App Service](https://docs.microsoft.com/fr-ca/azure/app-service/) offre un service d’hébergement web hautement évolutif appliquant des mises à jour correctives automatiques.

Ce guide de démarrage rapide montre comment déployer votre première application web ASP.NET Core sur Azure App Service. Quand vous aurez terminé, vous disposerez d’un groupe de ressources constitué d’un plan App Service et d’une application App Service avec une application web déployée.

[!INCLUDE [quickstarts-free-trial-note](../../includes/quickstarts-free-trial-note.md)]

## <a name="prerequisites"></a>Prérequis

Pour effectuer ce tutoriel, installez <a href="https://www.visualstudio.com/downloads/" target="_blank">Visual Studio 2019</a> avec la charge de travail **Développement web et ASP.NET**.

Si vous avez déjà installé Visual Studio 2019 :

- Installez les dernières mises à jour dans Visual Studio en sélectionnant **Aide** > **Rechercher les mises à jour**.
- Ajoutez la charge de travail en sélectionnant **Outils** > **Obtenir des outils et des fonctionnalités**.

## <a name="create-an-aspnet-core-web-app"></a>Créez une application web ASP.NET Core

Créez une application web ASP.NET Core en effectuant les étapes suivantes :

1. Ouvrez Visual Studio, puis sélectionnez **Créer un projet**.

1. Dans **Créer un projet**, recherchez et choisissez **Application web ASP.NET Core** pour C#, puis sélectionnez **Suivant**.

1. Dans **Configurer votre nouveau projet**, nommez l’application _myFirstAzureWebApp_, puis sélectionnez **Créer**.

   ![Configurer votre projet d’application web](./media/app-service-web-get-started-dotnet/configure-web-app-project.png)

1. Pour ce guide de démarrage rapide, choisissez le modèle **Application web**. Vérifiez que l’option d’authentification a la valeur **Aucune authentification** et qu’aucune autre option n’est sélectionnée. Sélectionnez **Create** (Créer).

   ![Sélectionner ASP.NET Core Razor Pages pour ce tutoriel](./media/app-service-web-get-started-dotnet/aspnet-razor-pages-app.png)

    Vous pouvez déployer n’importe quel type d’application web ASP.NET Core dans Azure.

1. Dans le menu Visual Studio, sélectionnez **Déboguer** > **Démarrer sans débogage** pour exécuter l’application web localement.

   ![Exécuter l’application localement](./media/app-service-web-get-started-dotnet/razor-web-app-running-locally.png)

## <a name="publish-your-web-app"></a>Publier votre application web

1. Dans l’**Explorateur de solutions**, cliquez avec le bouton droit sur le projet **myFirstAzureWebApp**, puis sélectionnez **Publier**.

1. Choisissez **App Service**, puis sélectionnez **Publier**.

   ![Publier à partir de la page de présentation du projet](./media/app-service-web-get-started-dotnet/publish-app-vs2019.png)

1. Dans **Créer un App Service**, vos options varient si vous êtes déjà connecté à Azure et si vous avez un compte Visual Studio lié à un compte Azure. Sélectionnez **Ajouter un compte** ou **Connexion** pour vous connecter à votre abonnement Azure. Si vous êtes déjà connecté, sélectionnez le compte souhaité.

   > [!NOTE]
   > Si vous êtes déjà connecté, ne sélectionnez pas encore **Créer**.
   >

   ![Connexion à Azure](./media/app-service-web-get-started-dotnet/sign-in-azure-vs2019.png)

   [!INCLUDE [resource group intro text](../../includes/resource-group.md)]

1. Pour **Groupe de ressources**, sélectionnez **Nouveau**.

1. Dans **Nouveau nom du groupe de ressources**, entrez *myResourceGroup*, puis sélectionnez **OK**.

   [!INCLUDE [app-service-plan](../../includes/app-service-plan.md)]

1. Pour le **Plan d’hébergement**, sélectionnez **Nouveau**.

1. Dans la boîte de dialogue **Configurer le plan d’hébergement**, entrez les valeurs du tableau suivant, puis sélectionnez **OK**.

   | Paramètre | Valeur suggérée | Description |
   |-|-|-|
   |Plan App Service| myAppServicePlan | Nom du plan App Service. |
   | Location | Europe Ouest | Centre de données dans lequel l’application web est hébergée. |
   | Size | Gratuit | Le [niveau tarifaire](https://azure.microsoft.com/pricing/details/app-service/?ref=microsoft.com&utm_source=microsoft.com&utm_medium=docs&utm_campaign=visualstudio) détermine les fonctionnalités d’hébergement. |

   ![Créer un plan App Service](./media/app-service-web-get-started-dotnet/app-service-plan-vs2019.png)

1. Dans **Nom**, entrez un nom d’application unique qui inclut uniquement les caractères valides `a-z`, `A-Z`, `0-9` et `-`. Vous pouvez accepter le nom unique généré automatiquement. L’URL de l’application web est `http://<app_name>.azurewebsites.net`, où `<app_name>` est le nom de votre application.

   ![Configurer le nom de l’application](./media/app-service-web-get-started-dotnet/web-app-name-vs2019.png)

1. Sélectionnez **Créer** pour commencer à créer les ressources Azure.

Une fois que l’Assistant a terminé, il publie l’application web ASP.NET Core sur Azure, puis il lance l’application dans le navigateur par défaut.

![Application web ASP.NET publiée dans Azure](./media/app-service-web-get-started-dotnet/web-app-running-live.png)

Le nom d’application spécifié dans la page **Créer un App Service** est utilisé en tant que préfixe d’URL au format `http://<app_name>.azurewebsites.net`.

**Félicitations !** Votre application web ASP.NET Core s’exécute en temps réel dans Azure App Service.

## <a name="update-the-app-and-redeploy"></a>Mise à jour de l’application et redéploiement

1. Dans l’**Explorateur de solutions**, sous votre projet, ouvrez **Pages** > **Index.cshtml**.

1. Remplacez les deux balises `<div>` par le code suivant :

   ```HTML
   <div class="jumbotron">
       <h1>ASP.NET in Azure!</h1>
       <p class="lead">This is a simple app that we’ve built that demonstrates how to deploy a .NET app to Azure App Service.</p>
   </div>
   ```

1. Pour effectuer un redéploiement dans Azure, cliquez avec le bouton droit sur le projet **myFirstAzureWebApp** dans **l’Explorateur de solutions**, puis sélectionnez **Publier**.

1. Dans la page récapitulative intitulée **Publier**, sélectionnez **Publier**.

   ![Page récapitulative de Visual Studio pour la publication](./media/app-service-web-get-started-dotnet/publish-summary-page-vs2019.png)

Une fois la publication terminée, Visual Studio lance un navigateur en accédant à l’URL de l’application web.

![Application web ASP.NET mise à jour dans Azure](./media/app-service-web-get-started-dotnet/web-app-running-live-updated.png)

## <a name="manage-the-azure-app"></a>Gérer l’application Azure

Pour gérer l’application web, accédez au [Portail Azure](https://portal.azure.com), puis recherchez et sélectionnez **App Services**.

![Sélectionner App Services](./media/app-service-web-get-started-dotnet/app-services.png)

Dans la page **App Services**, sélectionnez le nom de votre application web.

![Navigation au sein du portail pour accéder à l’application Azure](./media/app-service-web-get-started-dotnet/access-portal-vs2019.png)

Vous voyez apparaître la page Vue d’ensemble de votre application web. Ici, vous pouvez effectuer des tâches de gestion de base, par exemple parcourir, arrêter, démarrer, redémarrer et supprimer.

![App Service dans le portail Azure](./media/app-service-web-get-started-dotnet/web-app-general-vs2019.png)

Le menu de gauche fournit différentes pages vous permettant de configurer votre application.

[!INCLUDE [Clean-up section](../../includes/clean-up-section-portal.md)]

## <a name="next-steps"></a>Étapes suivantes

> [!div class="nextstepaction"]
> [Build a .NET Core and SQL Database web app in Azure App Service](app-service-web-tutorial-dotnetcore-sqldb.md) (Créer une application web .NET Core et SQL Database dans Azure App Service)

