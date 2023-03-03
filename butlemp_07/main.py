from flask import Flask

app = Flask(__name__)

@app.route('/')   ##@app.route - декоратор. один слэш(/) главная страница. Декораторы — это, по сути, "обёртки", которые дают нам возможность изменить поведение функции, не изменяя её код.

def main():    ##функция   (между декоратором и функцией нельзя писать прогр. код)
    return "<h1>Hello, World</h1><br><a href='/index'>перецти на 2-ю страницу</a>"


@app.route('/index/<x>/<y>')
def index(x,y):    
    return f'Результат: {int(x)+int(y)}'  ##f C:\Users\mivanova\Desktop\Гикбрейнс Иванова М\Csharp projects\Butkemp\butlemp_07\int(x)+int(y).jpg строка буквально означают «formatted string». Эти строки улучшают читаемость кода, а также работают быстрее чем другие способы форматирования. F-строки задаются с помощью литерала «f» перед кавычками.


if __name__=='__main__':
    app.run()