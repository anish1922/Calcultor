pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
               bat "rmdir /s /q Calculator"
			   bat "git clone https://github.com/anish1922/Calcultor.git"
			   bat "dotnet build "
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
