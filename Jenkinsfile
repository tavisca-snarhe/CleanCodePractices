pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                dotnet build
            }
        }
        stage('Test') {
            steps {
                dotnet test
            }
        }
    }
}