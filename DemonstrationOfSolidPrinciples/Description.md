## Single responsibility principle
*Каждый клаас отвечает за одну задачу*
- *GameLogic* - За логику игры
- *UserInput* - За ввод пользователя
- *SimpleRandomNumberGenerator* - отвечает за генерацию рандомного числа для игры.
## Open–closed principle
 Непонятная штука. Хочешь изменяй хочешь не изменяй. Самое главное не ломай, что и так нормально работает.
## Liskov substitution principle
*Все классы, которые реализуют интерфейсы, можно заменить на другие классы и также все будет работать*
## Interface segregation principle
*Все методы на своем месте.*
## Dependency inversion principle
Принцип инверсии зависимостей присутсвтует в папке _Abstrctions_
В классе *GameLogic* то, что нужно:
- private readonly IUserInterface _ui;
- private readonly IRandomNumberGenerator _random;
- private readonly IMessageProvider _messageProvider;