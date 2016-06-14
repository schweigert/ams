require 'Fleyhe' 	#gem install Fleyhe

class MainEvent < Fleyhe::Network::Event; end

class Log < MainEvent

	def solve
		puts "Working"
		auth = EDA::Funcionario.new @args[0], @args[1]
		if auth.autenticar
			@event = 'Log'
			@form = EDA::Log.getLog

		else
			@event = 'error'
		end
		puts "working"
	end

end

class Log < MainEvent

	def solve
		puts "Working"
		auth = EDA::Funcionario.new @args[0], @args[1]
		if auth.autenticar
			@event = 'Log'
			@form = EDA::Log.getLog

		else
			@event = 'error'
		end
		puts "working"
	end

end




module EDA

	class Funcionario

		def initialize login, password

			@nome = login
			@senha = password

		end

		def autenticar
			a = $db.execute "SELECT senha FROM Funcionario WHERE nome = '#{@nome.to_s.chomp}'"
			if a[0]['senha'] == @senha.chomp
				return true
			else
				return false
			end
		end

	end

	class Log
		def self.getLog
			registros = $db.execute "SELECT * FROM Log"

			ret = []
			for i in registros
				ret << "#{i['data']}: #{i['descricao']}"
			end

			return ret

		end
	end

end


$db = Fleyhe::Data::Database.new "database.db"
$listener = Fleyhe::Network::Listener.new 3030, MainEvent

loop {

	puts Time.now
	sleep 60

}