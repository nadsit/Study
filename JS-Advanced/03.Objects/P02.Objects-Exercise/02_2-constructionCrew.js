function constructionCrew(workerObject) { 
    if(workerObject.dizziness === true) {
        workerObject.levelOfHydrated = workerObject.levelOfHydrated + (0.1 * workerObject.weight * workerObject.experience);
        workerObject.dizziness = false;
    }
    
    return workerObject;
}
  
console.log(constructionCrew({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
  ));
console.log(constructionCrew({ weight: 120,
    experience: 20,
    levelOfHydrated: 200,
    dizziness: true }
  ));
  console.log(constructionCrew({ weight: 95,
    experience: 3,
    levelOfHydrated: 0,
    dizziness: false }
  ));