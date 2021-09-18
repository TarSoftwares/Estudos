var teste = 'teste TypeScript';
function Soma(x, y) {
    return x + y;
}
var pi = 3.14;
    var Matematica = /** @class */ (function () {
        function Matematica() {
        }
        Matematica.prototype.Somar = function (x, y) {
            return x + y;
        };
        Matematica.prototype.SomarDataDias = function (data, dias) {
            var diasData;
            diasData = data.getDate();
            return (diasData + dias);
        };
        return Matematica;
    }());
var s1;
s1 = 'Tarso França';
var n1;
n1 = 1000;
