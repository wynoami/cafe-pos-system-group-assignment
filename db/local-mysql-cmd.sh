#!/bin/bash

echo "usage: \`sudo $0\`"

echo "creating FWC database"
mysql -uroot < local-data-setup.sql

echo "creating cs_dev user"
mysql -uroot < local-create-user.sql

echo "rerun script if you encounter any issues."
