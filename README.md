# LC WAIKIKI CASE

## Table of contents

1. [Personel Information](#personel-information)
2. [Project Statements](#project-statements)
3. [Used Tecnologies](#used-tecnologies)
4. [Steps](#steps)
5. [Notes](#notes)
6. [Appreciation](#appreciation)

---

### Personel Information:
I have strong problem solving skills in software development and Devops Management. I have a futuristic working mind and innovative principles that I always follow the renewable and reliable technologies in IT Sector.

---
### Project Statements:
This is a project that has complete DevOps cycle.

---

### Used Tecnologies:
    Docker
    Kubernetes
    dotnet core 3.1
    CI/CD
    Vagrant
    
---

### Steps:
1. Prepared application received
2. Create a vagrant file for cluster 
3. Added Docker File to the project to Build it.Docker file has two stages. First stage is for installing dependencies. Second stage is for building the project.
* *docker build .*
4. Added .gitlab-ci.yml file, The image version is determined and stage is created.Docker Image is created by using Docker-in-Docker and pushed to the Gitlab Registry right after.
5. Added Kubernetes file.
* For out of network requests : Added nginxingress.yaml file
    - *kubectl apply -f nginxingress.yaml*
* Deployment : Added Application Name and Image Address in the deployment.yml
    - *kubectl apply -f deployment.yaml*
* Service : Added service.yaml file
    - *kubectl apply -f service.yaml*
* Proje has been tested and ran in local kubernetes cluster.

---

### Notes:
1. Instant projects outputs and other completed works/studies are attached as a PNG file in the İmagesForProject file.
---

### Appreciation:
Thank you and the lc waikiki family for giving me such an opportunity.



