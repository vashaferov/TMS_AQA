Feature: Параметризированные тесты
    
    Scenario: Простая параметризация
        Given открыт браузер
        * страница логина открыта
        When user "1" with password "2" logged in
        Then the addProjectButton if displayed
        * username is "3"
        * a project ID is 23
        
    Scenario Outline: Таблицы
        Given открыт браузер
        * страница логина открыта
        When user "<username>" with password "<password>" logged in
        Then username is "<visibleText>"
        
        Examples: 
        | username    | password | visibleText |
        | 1           | 2        | 3           |
        | a           | b        | c           |
        | asd@mail.ru | 123      | asd         |
        
    Scenario: Use big text
        Given a blog post named "Random" with Markdown body
        """markdown
        Some Title, Eh?
        ===============
        Here is the first paragraph of my blog post. Lorem ipsum dolor sit amet,
        consectetur adipiscing elit.
        """