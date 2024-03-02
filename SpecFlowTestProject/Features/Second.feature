Feature: Более сложный тест
    
    Scenario: Использование AND в Given
        Given открыт браузер
        And страница логина открыта
        Then поле username отображается
        
    Scenario: Использование But
        Given открыт браузер
        Then поле username отображается
        But кнопка login отображается