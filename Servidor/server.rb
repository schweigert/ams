require 'Fleyhe' 	#gem install Fleyhe

class Log < Fleyhe::Network::Event

	def solve
		@event 
	end

end

listener = Fleyhe::Network::Listener.new 3030, Event