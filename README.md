## Create Image

```bash
dotnet publish /t:PublishContainer
```

## Create Location For keys

```bash
mkdir data
```

## Run Image

```bash
# Or another port
docker run -v ./data:/home/app/.aspnet/DataProtection-Keys -p 55000:8080 -d test-docker
```

## Use DataProtection Key

```bash
curl http://localhost:55000/data?data=test
```

This should return a protected string, and you should have a key in your `./data` directory that
the container created.
