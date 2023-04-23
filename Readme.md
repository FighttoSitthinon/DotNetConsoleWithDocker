# Test Docker with .Net Core

Just project for test Docker with .Net Core


## Docker Usage

```
# Create Image from docker file
> docker build -t <image-name> -f Dockerfile .

# Create container from image 
> docker create --name <container-name> <image-name>

# start running the container
> docker start <container-name>

# stop running the container
> docker stop <container-name>

# Attach the current terminal to Input/Output the running container terminal
> docker attach --sig-proxy=false <container-name>
```

## Run only one time
```
# Create Image from docker file
> docker build -t <image-name> -f Dockerfile .

# Let the image create a container and start running after the end process terminates that container.
> docker run -it --rm <image-name>
```

## Other
```
# See running docker list
> docker ps -a
```

those CLI above will follow every command in DockerFile. 

Ref: https://learn.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows
