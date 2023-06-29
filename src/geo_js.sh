#!/bin/bash

api="https://get.geojs.io/v1"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function get_own_ip() {
	curl --request GET \
		--url "$api/ip.json" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_own_country() {
	curl --request GET \
		--url "$api/ip/country.json" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_country_by_ip() {
	# 1 - ip_address: (string): <ip_address>
	curl --request GET \
		--url "$api/ip/country/$1.json" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_own_geo() {
	curl --request GET \
		--url "$api/ip/geo.json" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_geo_by_ip() {
	# 1 - ip_address: (string): <ip_address>
	curl --request GET \
		--url "$api/ip/geo/$1.json" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_own_ptr() {
	curl --request GET \
		--url "$api/dns/ptr.json" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
