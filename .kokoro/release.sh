#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"
export NUGET_API_KEY="$(cat "$KOKORO_KEYSTORE_DIR"/73609_google-cloud-nuget-api-key)"

# Build the release and run the tests.
./buildrelease.sh --ssh $(git rev-parse HEAD)


# Add any docs changes if they exist.
cd ./releasebuild/releasedocs
git add --all
if ! git diff --quiet --cached; then git commit -m 'Regenerate docs'; git push; fi

cd ../..

# Push the changes to nuget.
cd ./releasebuild/nuget
for pkg in *.nupkg; do dotnet nuget push -s https://api.nuget.org/v3/index.json -k $NUGET_API_KEY $pkg; done

# Process the build log in releasebuild
cd ..
./processbuildtiminglog.sh
