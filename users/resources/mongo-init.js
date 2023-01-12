db.createUser(
    {
      user: "user",
      pwd: "naovoufalar",
      roles: [
        {
          role: "readWrite",
          db: "order-database"
        }
      ]
    }
);