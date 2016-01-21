# Get twilio-ruby from twilio.com/docs/ruby/install
require 'twilio-ruby'

# Get your Account Sid and Auth Token from twilio.com/user/account
account_sid = 'AC3094732a3c49700934481addd5ce1659'
auth_token = '{{ auth_token }}'
@client = Twilio::REST::PricingClient.new account_sid, auth_token


@countries = @client.phone_number.countries.list()
@countries.each do |c|
  puts c.iso_country
end
