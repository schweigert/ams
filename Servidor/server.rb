# Para instalar a biblioteca do Servidor:
#      Instalar SQLite3 na máquina
#      gem install sqlite3
#      gem install Fleyhe

require 'Fleyhe'

class MainEvent < Fleyhe::Network::Event; end

class Log < MainEvent
	def solve
		
	end
end

$db = Fleyhe::Data::Database.new "database.db"
$listener = Fleyhe::Network::Database.new 3030, MainEvent