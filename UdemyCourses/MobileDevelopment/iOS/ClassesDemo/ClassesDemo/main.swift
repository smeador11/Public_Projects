let skeleton = Enemy(health: 100, attackStrength: 10)
let skeleton2 = Enemy(health: 100, attackStrength: 10)

let dragon = Dragon()
print(skeleton.health)
skeleton.move()
skeleton.attack()

dragon.attackStrength = 15
dragon.health = 200
dragon.move()
dragon.attack()
dragon.talk(speech: "My teeth are swords! My claws are spears! My wings are a hurricane!")
print(dragon.health)
