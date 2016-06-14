require 'Fleyhe' 	#gem install Fleyhe

class Log < Fleyhe::Network::Event

	def solve
		
	end

end




module EDA

	class Funcionario

		def initialize login, password

			@login = login
			@password = password

		end

		def autenticar
			
		end

	end

end


$db = Fleyhe::Data::Database.new "database.db"
$listener = Fleyhe::Network::Listener.new 3030, Event

loop {

	puts Time.now
	sleep 60

}