function arenaTier(input) {
    let gladiators = new Map();

    for (const line of input) {

        if (line == "Ave Cesar") {
            break;
        }

        let items = line.split(" -> ");

        if (items.length > 2) {
            let [gladiator, technique, skill] = [items[0], items[1], Number(items[2])];

            if (!gladiators.get(gladiator)) {
                gladiators.set(gladiator, new Map());
            }

            if (!gladiators.get(gladiator).get(technique)) {
                gladiators.get(gladiator).set(technique, 0);
            }

            if (gladiators.get(gladiator).get(technique) < skill) {
                gladiators.get(gladiator).set(technique, skill);
            }

        } else {
            items = line.split(" vs ");
            let [gladiator1, gladiator2] = [items[0], items[1]];

            if (gladiators.get(gladiator1) && gladiators.get(gladiator2)) {
                let targetTechnique = [...gladiators.get(gladiator1)].map(key => key[0])
                    .find(item => [...gladiators.get(gladiator2)].map(key => key[0]).includes(item));

                if (targetTechnique) {
                    let gladiator1SkillPoints = gladiators.get(gladiator1).get(targetTechnique);
                    let gladiator2SkillPoints = gladiators.get(gladiator2).get(targetTechnique);

                    if (gladiator1SkillPoints > gladiator2SkillPoints) {
                        gladiators.delete(gladiator2);
                    } else {
                        gladiators.delete(gladiator1);
                    }
                }
            }
        }
    }

    let orderedResult = [...gladiators].filter(value => [...value[1]].reduce((skill, arr) => skill + arr[1], 0) > 0)
        .sort((a, b) => [...b[1]].reduce((skill, arr) => skill + arr[1], 0) - [...a[1]].reduce((skill, arr) => skill + arr[1], 0) ||
            a[0].localeCompare(b[0])); // at falsy value => 0 => ||

    for (const gladiator of orderedResult) {
        console.log(`${gladiator[0]}: ${[...gladiator[1]].reduce((skill, arr) => skill + arr[1], 0)} skill`);

        for (const item of [...gladiator[1]].sort((a, b) => b[1] - a[1] || a[0].localeCompare(b[0]))) {
            console.log(`- ${item[0]} <!> ${item[1]}`);
        }
    }
}

arenaTier(['Pesho -> BattleCry -> 400',
    'Gosho -> PowerPunch -> 300',
    'Stamat -> Duck -> 200',
    'Stamat -> Tiger -> 250',
    'Ave Cesar'
]);

arenaTier(['Pesho -> Duck -> 400',
    'Julius -> Shield -> 150',
    'Gladius -> Heal -> 200',
    'Gladius -> Support -> 250',
    'Gladius -> Shield -> 250',
    'Pesho vs Gladius',
    'Gladius vs Julius',
    'Gladius vs Gosho',
    'Ave Cesar'
]);