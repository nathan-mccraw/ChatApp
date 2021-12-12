import { useState } from "react";
import axios from "axios";
import { useAuthContext } from "./useAuthContext";

export const useSignUpGuest = () => {
  const [error, setError] = useState(null);
  const [isPending, setIsPending] = useState(null);
  const { dispatch } = useAuthContext();

  const signUpGuest = async () => {
    setError(null);
    setIsPending(true);
    try {
      let sessResponse = await axios.get("/api/signup");
      console.log(sessResponse);
      if (sessResponse.status === 200) {
        dispatch({ type: "UPDATE_SESSION", payload: sessResponse.data });
        let userId = sessResponse.data.userId;
        let userResponse = await axios.get(`/api/users/${userId}`);
        dispatch({ type: "UPDATE_PROFILE", payload: userResponse.data });
        setIsPending(false);
        setError(null);
      } else {
        throw new Error(sessResponse);
      }
    } catch (error) {
      console.log(error);
      setError(error.message);
      setIsPending(false);
    }
  };

  return { error, isPending, signUpGuest };
};
