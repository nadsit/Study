function createHeroes() {
  const canCast = (state) => ({
    cast: (spell) => {
      console.log(`${state.name} cast ${spell}`);
      state.mana--;
    },
  });

  const canFight = (state) => ({
    fight: () => {
      console.log(`${state.name} slashes at the foe!`);
      state.stamina--;
    },
  });

  const fighter = (name) => {
    let state = {
      name,
      health: 100,
      stamina: 100,
    };

    return Object.assign(state, canFight(state));
    //The Object.assign() method copies all enumerable own properties
    //from one or more source objects to a target object. It returns the target object.
    //Parameters:
    //target
    //The target object — what to apply the sources’ properties to, which is returned after it is modified.
    //sources
    //The source object(s) — objects containing the properties you want to apply.
    //Return value
    //The target object.
  };

  const mage = (name) => {
    let state = {
      name,
      health: 100,
      mana: 100,
    };

    return Object.assign(state, canCast(state));
  };

  return { mage, fighter };
}

let create = createHeroes();
const scorcher = create.mage("Scorcher");
scorcher.cast("fireball");
scorcher.cast("thunder");
scorcher.cast("light");

const scorcher2 = create.fighter("Scorcher 2");
scorcher2.fight();

console.log(scorcher2.stamina);
console.log(scorcher.mana);
