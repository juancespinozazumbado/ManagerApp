## The core layer
This layer is conforming by the Domain project and the Aplication project

### Doamin

The domain project contains all the domain elements like Domain entities, Agregates, Enums.
The domain project can´t reference any other project, adn can be reference by all projects.

### Aplication

The aplication project contains all the business rules of the aplication.
It consist of abstractions that can be implemented in outher projects like infraestructure.

some interfaces like Repositories, Services and the main features are developed in this project.
