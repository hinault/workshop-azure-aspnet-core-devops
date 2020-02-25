# Utiliser Azure SQL Database

<a href="https://docs.microsoft.com/fr-ca/azure/sql-database/">Azure SQL Database</a> est un service que vous utilisez pour créer une base de données relationnelle dans le cloud compatible avec Microsoft SQL Server. SQL Database est un service hautement évolutif. Il peut prendre en charge plusieurs milliers de demandes simultanées. Dans SQL Database, vous pouvez définir des tables, puis insérer, mettre à jour, supprimer et interroger des données.

##  Objectif

Pour cette troisième partie du laboratoire, les participants vont créer une base de données Azure SQL Database en utilisant le portail Azure. Ils vont ensuite configurer leur application Web pour se connecter à la base de données et l'interroger.

## Créer une base de données Azure SQL 

1. Ouvrez le portail Azure (portal.azure.com).

2. Cliquez sur le bouton **Créer une ressource**

3. Dans la fenêtre qui va s'afficher, saisir dans la zone de recherche, saisir **SQL Database** et selectionner le service correspondant

  ![Création SQL Database](./media/new-sql-db.png)

4. Dans la fenêtre qui va s'afficher, cliquez sur le bouton **Créer**

4. Sous l’onglet **Bases**, dans la section **Détails du projet**, tapez ou sélectionnez les valeurs suivantes :

   - **Abonnement**: Faites défiler la liste et sélectionnez l’abonnement approprié, s’il n’apparaît pas.
   - **Groupe de ressources** : sélectionnez **Créer**, tapez `myResourceGroup`, puis sélectionnez **OK**.

     ![Nouvelle base de données SQL - Onglet des informations de base](../media/sql-database-get-started-portal/new-sql-database-basics.png)

5. Dans la section formulaire **Détails de la base de données**, tapez ou sélectionnez les valeurs suivantes :

   - **Nom de la base de données** : Entrez `mySampleDatabase`.
   - **Serveur** : sélectionnez **Créer**, entrez les valeurs suivantes, puis sélectionnez **Sélectionner**.
       - **Nom du serveur** : tapez `mysqlserver` ainsi que des chiffres à des fins d’unicité.
       - **Connexion administrateur au serveur** : Tapez `azureuser`.
       - **Mot de passe** : tapez un mot de passe complexe qui répond aux exigences de mot de passe.
       - **Emplacement** : choisissez un emplacement dans la liste déroulante, tel que `West US`.

         ![Nouveau serveur](../media/sql-database-get-started-portal/new-server.png)

      > [!IMPORTANT]
      > Mémorisez votre nom d’utilisateur et mot de passe de connexion d’administrateur au serveur, car vous en aurez besoin pour vous connecter au serveur et aux bases de données dans le cadre de ce guide ou d’autres guides de démarrage rapide. Si vous oubliez votre mot de passe ou vos identifiants de connexion, vous pouvez obtenir le nom de connexion ou réinitialiser le mot de passe sur la page **SQL Server**. Pour ouvrir la page **SQL Server** , sélectionnez le nom du serveur sur la page **Vue d’ensemble** de la base de données une fois cette dernière créée.

   - **Vous souhaitez utiliser un pool élastique SQL ?**  : sélectionnez l’option **Non**.
   - **Calcul + stockage** : Sélectionnez **Configurer la base de données**. 

     ![Détails de la base de données SQL](../media/sql-database-get-started-portal/sql-db-basic-db-details.png)

   - Sélectionnez **Provisionné**.

     ![Gen4 provisionné](../media/sql-database-get-started-portal/create-database-provisioned.png)

   - Passez en revue les paramètres pour **vCores** et **Taille max. des données**. Modifiez-les comme vous le souhaitez. 
     - Si vous le souhaitez, vous pouvez également sélectionner **Changer la configuration** pour modifier la génération matérielle.
   - Sélectionnez **Appliquer**.

6. Sélectionnez l’onglet **Réseau** et décidez si vous souhaitez [**Autoriser les services et ressources Azure à accéder à ce serveur**](../sql-database-networkaccess-overview.md), ou ajoutez un [point de terminaison privé](../../private-link/private-endpoint-overview.md).

   ![Onglet Réseau](../media/sql-database-get-started-portal/create-database-networking.png)

7. Sélectionnez l’onglet **Paramètres supplémentaires**. 
8. Dans la section **Source de données**, sous **Utiliser des données existantes**, sélectionnez `Sample`.

   ![Paramètres supplémentaires de la base de données SQL](../media/sql-database-get-started-portal/create-sql-database-additional-settings.png)

   > [!IMPORTANT]
   > Veillez à sélectionner les données **Exemple (AdventureWorksLT)** pour pouvoir facilement suivre le présent guide ainsi que d’autres articles dédiés à Azure SQL Database qui utilisent ces données.

9. Laissez le reste des valeurs par défaut, puis sélectionnez **Vérifier + créer** en bas du formulaire.
10. Passez en revue les paramètres finaux et sélectionnez **Créer**.

11. Sur le formulaire **SQL Database**, sélectionnez **Créer** pour déployer et configurer le groupe de ressources, le serveur et la base de données.


## Ouvrir le projet de demarrage</a>

1. Ouvrez Visual Studio, puis sélectionnez **Ouvrir un projet ou une solution**.

 ![Ouverture projet](./media/open-project.png)

2. Ouvrez la solution de l'étape 3 (\Etape 3 - Utiliser Azure SQL Database\Workshop\Workshop.sln).
